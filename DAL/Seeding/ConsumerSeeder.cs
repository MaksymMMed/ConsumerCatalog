using DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeding
{
    public class ConsumerSeeder : ISeeder<Consumer>
    {
        private static readonly List<Consumer> consumers = new()
        {
        new Consumer{
            Id = 1,
            FirstName = "Reuben",
            LastName = "Mcconnell"
        },
        new Consumer{
            Id = 2,
            FirstName = "Shelly",
            LastName = "Fitzgerald"
        },
        new Consumer{
            Id = 3,
            FirstName = "Odette",
            LastName = "Dixon"
        },
        new Consumer{
            Id = 4,
            FirstName = "McKenzie",
            LastName = "Morales"
        },
        new Consumer{
            Id = 5,
            FirstName = "Norman",
            LastName = "Dominguez"
        },
        new Consumer{
            Id = 6,
            FirstName = "Peter",
            LastName = "Briggs"
        },
        new Consumer{
            Id = 7,
            FirstName = "Tatyana",
            LastName = "Santiago"
        },
        new Consumer{
            Id = 8,
            FirstName = "Quyn",
            LastName = "Fisher"
        },
        new Consumer{
            Id = 9,
            FirstName = "Macon",
            LastName = "Alford"
        },
        new Consumer{
            Id = 10,
            FirstName = "Lani",
            LastName = "Vance"
        },
        new Consumer{
            Id = 11,
            FirstName = "Nigel",
            LastName = "Brown"
        },
        new Consumer{
            Id = 12,
            FirstName = "Xenos",
            LastName = "Britt"
        },
        new Consumer{
            Id = 13,
            FirstName = "Scarlet",
            LastName = "Hardin"
        },
        new Consumer{
            Id = 14,
            FirstName = "Honorato",
            LastName = "Caldwell"
        },
        new Consumer{
            Id = 15,
            FirstName = "Amir",
            LastName = "Wilson"
        },
        new Consumer{
            Id = 16,
            FirstName = "Bevis",
            LastName = "Mitchell"
        },
        new Consumer{
            Id = 17,
            FirstName = "Chase",
            LastName = "Conley"
        },
        new Consumer{
            Id = 18,
            FirstName = "Stephanie",
            LastName = "Campbell"
        },
        new Consumer{
            Id = 19,
            FirstName = "Raphael",
            LastName = "Delacruz"
        },
        new Consumer{
            Id = 20,
            FirstName = "Deacon",
            LastName = "Stanton"
        },
        new Consumer{
            Id = 21,
            FirstName = "Emmanuel",
            LastName = "Johnston"
        },
        new Consumer{
            Id = 22,
            FirstName = "Beverly",
            LastName = "Crosby"
        },
        new Consumer{
            Id = 23,
            FirstName = "Wyoming",
            LastName = "Knox"
        },
        new Consumer{
            Id = 24,
            FirstName = "Xandra",
            LastName = "Mclean"
        },
        new Consumer{
            Id = 25,
            FirstName = "Kyla",
            LastName = "Mathis"
        },
        new Consumer{
            Id = 26,
            FirstName = "Elijah",
            LastName = "Mckenzie"
        },
        new Consumer{
            Id = 27,
            FirstName = "Scott",
            LastName = "Cash"
        },
        new Consumer{
            Id = 28,
            FirstName = "Judith",
            LastName = "Petty"
        },
        new Consumer{
            Id = 29,
            FirstName = "Jermaine",
            LastName = "Weaver"
        },
        new Consumer{
            Id = 30,
            FirstName = "Gail",
            LastName = "Simmons"
        },
        new Consumer{
            Id = 31,
            FirstName = "Tarik",
            LastName = "Frederick"
        },
        new Consumer{
            Id = 32,
            FirstName = "Xander",
            LastName = "Rivers"
        },
        new Consumer{
            Id = 33,
            FirstName = "Jonas",
            LastName = "Glover"
        },
        new Consumer{
            Id = 34,
            FirstName = "Hector",
            LastName = "Pacheco"
        },
        new Consumer{
            Id = 35,
            FirstName = "Anika",
            LastName = "Mercado"
        },
        new Consumer{
            Id = 36,
            FirstName = "Gage",
            LastName = "Bryant"
        },
        new Consumer{
            Id = 37,
            FirstName = "Ginger",
            LastName = "Hendrix"
        },
        new Consumer{
            Id = 38,
            FirstName = "Ezekiel",
            LastName = "Cote"
        },
        new Consumer{
            Id = 39,
            FirstName = "Lillian",
            LastName = "Powell"
        },
        new Consumer{
            Id = 40,
            FirstName = "Bo",
            LastName = "Huff"
        },
        new Consumer{
            Id = 41,
            FirstName = "Hermione",
            LastName = "Hobbs"
        },
        new Consumer{
            Id = 42,
            FirstName = "Avram",
            LastName = "Jennings"
        },
        new Consumer{
            Id = 43,
            FirstName = "Mara",
            LastName = "Moss"
        },
        new Consumer{
            Id = 44,
            FirstName = "Allegra",
            LastName = "Tyson"
        },
        new Consumer{
            Id = 45,
            FirstName = "Mara",
            LastName = "Bruce"
        },
        new Consumer{
            Id = 46,
            FirstName = "Idona",
            LastName = "Griffin"
        },
        new Consumer{
            Id = 47,
            FirstName = "Yasir",
            LastName = "Galloway"
        },
        new Consumer{
            Id = 48,
            FirstName = "Derek",
            LastName = "Park"
        },
        new Consumer{
            Id = 49,
            FirstName = "Victor",
            LastName = "Pena"
        },
        new Consumer{
            Id = 50,
            FirstName = "Shay",
            LastName = "Wilder"
        },
        new Consumer{
            Id = 51,
            FirstName = "Desiree",
            LastName = "Blair"
        },
        new Consumer{
            Id = 52,
            FirstName = "Lenore",
            LastName = "Glass"
        },
        new Consumer{
            Id = 53,
            FirstName = "Ferdinand",
            LastName = "Valenzuela"
        },
        new Consumer{
            Id = 54,
            FirstName = "Kennan",
            LastName = "Downs"
        },
        new Consumer{
            Id = 55,
            FirstName = "Heather",
            LastName = "Clayton"
        },
        new Consumer{
            Id = 56,
            FirstName = "Chantale",
            LastName = "Pearson"
        },
        new Consumer{
            Id = 57,
            FirstName = "Maggie",
            LastName = "Knight"
        },
        new Consumer{
            Id = 58,
            FirstName = "Aiko",
            LastName = "Cook"
        },
        new Consumer{
            Id = 59,
            FirstName = "Macy",
            LastName = "Francis"
        },
        new Consumer{
            Id = 60,
            FirstName = "Ali",
            LastName = "Walsh"
        },
        new Consumer{
            Id = 61,
            FirstName = "Dieter",
            LastName = "Hartman"
        },
        new Consumer{
            Id = 62,
            FirstName = "Keegan",
            LastName = "Oneil"
        },
        new Consumer{
            Id = 63,
            FirstName = "Leo",
            LastName = "Francis"
        },
        new Consumer{
            Id = 64,
            FirstName = "Wang",
            LastName = "Wallace"
        },
        new Consumer{
            Id = 65,
            FirstName = "Evelyn",
            LastName = "Leach"
        },
        new Consumer{
            Id = 66,
            FirstName = "Lois",
            LastName = "Mills"
        },
        new Consumer{
            Id = 67,
            FirstName = "Carol",
            LastName = "Kidd"
        },
        new Consumer{
            Id = 68,
            FirstName = "Liberty",
            LastName = "Dotson"
        },
        new Consumer{
            Id = 69,
            FirstName = "Deacon",
            LastName = "Benson"
        },
        new Consumer{
            Id = 70,
            FirstName = "Ayanna",
            LastName = "Koch"
        },
        new Consumer{
            Id = 71,
            FirstName = "Sybil",
            LastName = "Soto"
        },
        new Consumer{
            Id = 72,
            FirstName = "Dominic",
            LastName = "Cash"
        },
        new Consumer{
            Id = 73,
            FirstName = "Thor",
            LastName = "Guerrero"
        },
        new Consumer{
            Id = 74,
            FirstName = "Keefe",
            LastName = "Morris"
        },
        new Consumer{
            Id = 75,
            FirstName = "Kato",
            LastName = "Franks"
        },
        new Consumer{
            Id = 76,
            FirstName = "Carissa",
            LastName = "Lawrence"
        },
        new Consumer{
            Id = 77,
            FirstName = "Zeus",
            LastName = "Luna"
        },
        new Consumer{
            Id = 78,
            FirstName = "Herman",
            LastName = "Evans"
        },
        new Consumer{
            Id = 79,
            FirstName = "Lars",
            LastName = "Moreno"
        },
        new Consumer{
            Id = 80,
            FirstName = "Mia",
            LastName = "Cohen"
        },
        new Consumer{
            Id = 81,
            FirstName = "Larissa",
            LastName = "Walsh"
        },
        new Consumer{
            Id = 82,
            FirstName = "Lani",
            LastName = "Whitaker"
        },
        new Consumer{
            Id = 83,
            FirstName = "Wing",
            LastName = "Owens"
        },
        new Consumer{
            Id = 84,
            FirstName = "Brenda",
            LastName = "Dixon"
        },
        new Consumer{
            Id = 85,
            FirstName = "Stella",
            LastName = "Hodges"
        },
        new Consumer{
            Id = 86,
            FirstName = "Orla",
            LastName = "Mcintosh"
        },
        new Consumer{
            Id = 87,
            FirstName = "Victoria",
            LastName = "Dillon"
        },
        new Consumer{
            Id = 88,
            FirstName = "Jana",
            LastName = "Alvarez"
        },
        new Consumer{
            Id = 89,
            FirstName = "Alana",
            LastName = "Kirkland"
        },
        new Consumer{
            Id = 90,
            FirstName = "Steven",
            LastName = "Arnold"
        },
        new Consumer{
            Id = 91,
            FirstName = "Ebony",
            LastName = "Osborne"
        },
        new Consumer{
            Id = 92,
            FirstName = "Azalia",
            LastName = "Oliver"
        },
        new Consumer{
            Id = 93,
            FirstName = "Salvador",
            LastName = "Owen"
        },
        new Consumer{
            Id = 94,
            FirstName = "Jolene",
            LastName = "Jarvis"
        },
        new Consumer{
            Id = 95,
            FirstName = "Price",
            LastName = "Pruitt"
        },
        new Consumer{
            Id = 96,
            FirstName = "Brody",
            LastName = "Duffy"
        },
        new Consumer{
            Id = 97,
            FirstName = "Macy",
            LastName = "Suarez"
        },
        new Consumer{
            Id = 98,
            FirstName = "Meredith",
            LastName = "Francis"
        },
        new Consumer{
            Id = 99,
            FirstName = "Gisela",
            LastName = "Hyde"
        },
        new Consumer{
            Id = 100,
            FirstName = "Clinton",
            LastName = "Gilmore"
        }
    };
        public void Seeding(EntityTypeBuilder<Consumer> builder) => builder.HasData(consumers);
    }
}
