using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Создать приложение для работы магазина продающего
 *  музыкальные альбомы музыкальных групп и исполнителей
 *  В приложении должны быть реализованы CRUD - операции:
 *  CREATE, READ, UPDATE, DELETE.
 *  Т.е. пользователь приложения может создать запись
 *  содержащую информацию о новом альбоме, изменить альбом,
 *  удалить альбом, вывести информацию об альбоме.
 *
 *  Также в приложении необходимо реализовать поиск:
 *  - Всех альбомов и их исполнителей по имени исполнителя
 *  (музыкальной группы)
 *  - Вывод только информации об исполнителях
 *  имеющихся в базе (Имя Фамилия (либо название группы)),
 *  Год рождения (либо дата основания группы), Биография
 *  (история существования группы)
 *  - Вывод информации только о музыкальных альбомах
 *  (Исполнитель (Группа), Название альбома, год выпуска,
 *  стоимость, есть альбом в наличии или нет)
 *  - По дате выпуска музыкального альбома
 *  - По цене
 *  - По названию музыкального альбома
 *  - Вывод всех альбомов отсортированных по имени исполнителя
 *  - Отсортированных по названию альбома
 *  - Отсортированных по дате выпуска
 *
 *  В приложении должен присутствовать класс РЕПОЗИТОРИЙ,
 *  имитирующий базу данных в которой хранятся альбомы.
 *  Репозиторий заполнить минимум 10-ю музыкальными альбомами.
 *  Создать удобное меню для работы, а также реализовать работу
 *  приложения через аргументы командной строки.
 */
namespace exercise
{
    interface IAlbumInfo
    {
        void GetAlbumInfo();
        void GetArtistInfo();
    }
    interface IAlbum : IAlbumInfo
    {
        string Name { get; }
        string Title { get; }
        DateTime ReleaseYear { get; }
        int Price { get; }
        bool Availability { get; }
    }
     class Artist : IAlbum, IAlbumInfo
    {
        public string Name { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string Biography { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Price { get; set; }
        public bool Availability { get; set;}
        
        public void GetArtistInfo()
        {
            Console.WriteLine($"Имя артиста {Name}\nДата рождения: {YearOfBirth}\nБиография: {Biography}\n");
        }
        public void GetAlbumInfo()
        {
            Console.WriteLine($"Название альбома: {Title}\nДата релиза: {ReleaseYear}\nЦена: {Price}\nНаличие: {Availability}\n");
        }

    }
    public class Group : IAlbum, IAlbumInfo
    {
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string HistoryOfGroup { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Price { get; set; }
        public bool Availability { get; set; }
        public void GetArtistInfo()
        {
            Console.WriteLine($"Группа: {Name}\nДата основания: {FoundingDate}\nКраткая история группы:\n{HistoryOfGroup}\n");
        }
        public void GetAlbumInfo()
        {
            Console.WriteLine($"Название альбома: {Title}\nДата релиза: {ReleaseYear}\nЦена: {Price}\nНаличие: {Availability}\n");
        }
    }

    
    internal class Program
    {

        public static void CreateArtistAlbum()
        {
            Console.WriteLine("Введите имя артиста");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите название альбома");
            string nameAlbum = Console.ReadLine();
            Console.WriteLine("Введите дату релиза");
            DateTime release = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите наличие (true\false)");
            bool availability = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите биографию артиста");
            string biography = Console.ReadLine();           

            Repository.albums.Add( new Artist() {Name = name, YearOfBirth = birthDay, Title = nameAlbum,
                ReleaseYear = release, Price = price, Availability = availability, Biography = biography});
        }
        public static void CreateGroupAlbum()
        {
            Console.WriteLine("Введите название группы");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату основания");
            DateTime foundationDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите название альбома");
            string nameAlbum = Console.ReadLine();
            Console.WriteLine("Введите дату релиза");
            DateTime release = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите наличие (true\false)");
            bool availability = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите краткую историю группы");
            string history = Console.ReadLine();

            Repository.albums.Add(new Group()
            {
                Name = name,
                FoundingDate = foundationDate,
                Title = nameAlbum,
                ReleaseYear = release,
                Price = price,
                Availability = availability,
                HistoryOfGroup = history
            });
        }
        /// <summary>
        /// Всех альбомов и их исполнителей по имени исполнителя (музыкальной группы)
        /// </summary>
        public static void PrintAlbumFromArtistName()
        {
            
        }

        static void Main(string[] args)
        {
            var albums = Repository.albums;

            foreach (var item in albums)
            {
                item.GetAlbumInfo();
                Console.WriteLine();
            }          


            int userInput;
            do
            {
                Console.WriteLine("1 - Создать новый альбом артиста\n2 - Создать новый альбом группы\n3 - Поиск альбома по исполнителю\n4 - Поиск информации по исполнителю\n" +
                    "5 - Поиск информации об альбоме по исполнителю\n6 - Поиск по цене\n7 - Поиск по названию альбома\n8 - Поиск по дате релиза\n" +
                    "9 - Вывод всех альбомов отсортированных по имени исполнителя\n10 - Вывод всех альбомов отсортированных по названию альбома\n" +
                    "11 - Вывод всех альбомов отсортированных по дате релиза\n12 - Вывод всех альбомов\n0 - Выход");
                Console.WriteLine("Выберите действие");
                userInput = int.Parse(Console.ReadLine());
                string name = "";                
                switch (userInput)
                {
                    
                    case 1:
                        CreateArtistAlbum();
                        Console.WriteLine("Альбом добавлен.\n");
                        break;
                    case 2:
                        CreateGroupAlbum();
                        Console.WriteLine("Альбом добавлен.\n");
                        break;
                    case 3:
                        Console.WriteLine("Введите имя исполнителя или название группы");
                        name = Console.ReadLine();
                        var result3 = Repository.albums.Where(x => x.Name.Contains(name));
                        Console.WriteLine("Информация по альбомам:\n");
                        foreach (var album in result3)
                        {
                            album.GetArtistInfo();
                            album.GetAlbumInfo();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите имя исполнителя или название группы");
                        name = Console.ReadLine();
                        var result4 = Repository.albums.Where(x => x.Name.Contains(name));
                        foreach (var album in result4)
                        {
                            album.GetArtistInfo();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите имя исполнителя или название группы");
                        name = Console.ReadLine();
                        var result5 = Repository.albums.Where(x => x.Name.Contains(name));
                        foreach (var album in result5)
                        {
                            album.GetAlbumInfo();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Введите цену альбома");
                        int userPrice = int.Parse(Console.ReadLine());
                        var result6 = Repository.albums.Where(x => x.Price == userPrice);
                        foreach (var album in result6)
                        {
                            album.GetAlbumInfo();
                            album.GetArtistInfo();
                        }
                        break;
                    case 7:
                        Console.WriteLine("Введите название альбома");
                        name = Console.ReadLine();
                        var result7 = Repository.albums.Where(x => x.Title.Contains(name));
                        foreach (var album in result7)
                        {
                            album.GetAlbumInfo();
                            album.GetArtistInfo();
                        }
                        break;
                    case 8:
                        Console.WriteLine("Введите дату релиза альбома");
                        DateTime dateTime = DateTime.Parse(Console.ReadLine());
                        var result8 = Repository.albums.Where(x => x.ReleaseYear == dateTime);
                        foreach (var album in result8)
                        {
                            album?.GetAlbumInfo();
                            album?.GetArtistInfo();
                        }
                        break;
                    case 9:
                        Console.WriteLine("Все альбомы отсортированные по имени исполнителя");
                        var result9 = Repository.albums.OrderBy(x => x.Name);
                        foreach (var album in result9)
                        {
                            album.GetArtistInfo();
                            album.GetAlbumInfo();
                        }
                        break;
                    case 10:
                        Console.WriteLine("все альбомы отсортированные по названию альбома");
                        var result10 = Repository.albums.OrderBy(x => x.Title);
                        foreach (var album in result10)
                        {
                            album.GetAlbumInfo();
                            album.GetArtistInfo();
                        }
                        break;
                    case 11:
                        Console.WriteLine("Все альбомы отсортированные по дате релиза");
                        var result11 = Repository.albums.OrderBy(x => x.ReleaseYear);
                        foreach (var album in result11)
                        {
                            album.GetArtistInfo();
                            album.GetAlbumInfo();
                        }
                        break;
                    case 12:
                        Console.WriteLine("Все альбомы");
                        foreach (var album in albums)
                        {
                            album.GetAlbumInfo();
                            album.GetArtistInfo();
                        }
                        break;
                    default:
                        if (userInput == 0)
                        {
                            Console.WriteLine("Завершение работы.\nВсего доброго!");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода команды.");
                        }
                        break;
                }
            } while (userInput != 0) ;
        Console.ReadLine();
        }
    }
}
