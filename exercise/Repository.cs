using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Repository
    {
        public static List<IAlbum> albums  = new List<IAlbum>()
        {
           new Group {Name ="Пикник", FoundingDate = new DateTime(1978,02,01), Price= 1500, Title = "Говорит и показывает", ReleaseYear = new DateTime(2003,06,15), Availability = true, HistoryOfGroup= "советская и российская рок-группа, основанная в Ленинграде в 1978 году."},
           new Group {Name ="Linkin Park", FoundingDate= new DateTime(2000, 05,04), HistoryOfGroup= "американская рок-группа, основанная в 1996 году под названием Xero и исполняющая музыку преимущественно в стилях альтернативный метал, ню-метал и рэп-метал (раннее творчество)," +
               " альтернативный рок, электроник-рок, поп и поп-рок (позднее творчество). " +
               "Существуя с 2000 года под названием Linkin Park, группа была шесть раз номинирована и два раза удостоилась награды «Грэмми».", Price = 1800, Title = "Meteora", ReleaseYear = new DateTime(2003,03,25), Availability = true},
           new Group {Name = "Nirvana", FoundingDate = new DateTime(1987,03,03), HistoryOfGroup = " американская рок-группа, созданная вокалистом и гитаристом Куртом Кобейном и басистом Кристом Новоселичем в Абердине, штат Вашингтон, в 1987 году.",
                    Price = 1600, Title = "Nevermind", Availability = true, ReleaseYear = new DateTime(1991,09,24)},
           new Group {Name = "Агата Кристи", FoundingDate = new DateTime(1987,05,13), HistoryOfGroup= "«Ага́та Кри́сти» — советская и российская рок-группа, одна из наиболее популярных в стране в середине и во второй половине 1990-х годов.", Price = 2000, ReleaseYear = new DateTime(1997,03,10), Title = "Ураган", Availability = true},
           new Group {Name = "Кукрыниксы", FoundingDate = new DateTime(1997, 07,17), HistoryOfGroup = "российская рок-группа, основанная Алексеем Горшенёвым («Ягодой»), младшим братом Михаила Горшенёва («Горшка»), лидера группы «Король и Шут».",
                        Title = "Шаман", Price = 1750, Availability = true, ReleaseYear = new DateTime(2006,10,07)},
           new Artist {Name = "Егор Летов", YearOfBirth = new DateTime(1964,09,10), Biography = "Игорь Фёдорович Летов (10 сентября 1964, Омск, РСФСР, СССР — 19 февраля 2008, Омск, Россия), более известный как Его́р Ле́тов, — советский и российский музыкант, певец, звукорежиссёр, художник-оформитель, коллажист и поэт." +
               " Основатель, лидер и единственный постоянный участник группы «Гражданская оборона», также известен по музыкальным проектам «Егор и Оп********е» =), «Коммунизм» и др.", Title = "Невыносимая лёгкость бытия", ReleaseYear = new DateTime(1997,05,06), Price = 1800, Availability = true},
           new Group {Name = "Анимация", FoundingDate = new DateTime(2000, 06,16), HistoryOfGroup= "российская рок-группа, образованная в 2000 году в городе Чистополь (Татарстан). Лидер — Константин Кулясов.", Title = "ВО", Price = 1650, ReleaseYear = new DateTime(2019,07,01), Availability = true},
           new Artist { Name = "Дэвид Боуи", Biography = " британский рок-музыкант, певец и автор песен, а также продюсер, звукорежиссёр, художник и актёр. " +
               "На протяжении пятидесяти лет часто переосмыслял свою карьеру, успешно сочетая творчество с актуальными музыкальными направлениями, благодаря чему получил прозвище «хамелеон рок-музыки»." +
               " При этом ему удавалось сохранять собственный узнаваемый стиль, за счёт характерной манеры исполнения и интеллектуальной глубины созданных им работ. Боуи считается новатором, в частности, благодаря своим музыкальным экспериментам в конце 1970-х.", YearOfBirth = new DateTime(1947,01,08),
                    Title = "Black Tie White Noise", Availability = false, Price = 1444, ReleaseYear = new DateTime(1993,04,05)},
           new Artist {Name ="Игги Поп", YearOfBirth = new DateTime(1947,04,21), Biography = "Джеймс Нью́эл О́стерберг-младший (англ. James Newell Osterberg, Jr.; 21 апреля 1947 года, Маскигон  (англ.)рус., Мичиган, США)," +
               " более известный как И́гги Поп (Iggy Pop) — американский рок-вокалист, один из зачинателей и гуру альтернативного рока. За вклад в развитие рок-альтернативы его величают «крёстным отцом» (иногда «дедушкой») панк-рока и гранжа." +
               " В 2009 году британский журнал Classic Rock удостоил его звания «Живая легенда».", Title ="Brick by Brick", ReleaseYear = new DateTime(1990, 02, 15), Price = 2000, Availability = false},
           new Artist{Name = "Оззи Осборн", YearOfBirth = new DateTime(1948,12,03), Biography = " британский рок-певец, музыкант, один из основателей и участник группы Black Sabbath, оказавшей значительное влияние на появление таких музыкальных стилей, как хард-рок и хеви-метал. Успешность его карьеры и популярность принесли ему неофициальный титул «Крёстный отец хэви-метала».", Availability = false,
                    Title = "Down to Earth", Price = 1800, ReleaseYear = new DateTime(2001,10,06)}
        };
    }
    
}