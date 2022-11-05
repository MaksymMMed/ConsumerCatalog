using DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeding
{
    public class UnitSeeder : ISeeder<Unit>
    {
        private static readonly List<Unit> units = new(){
        new Unit{
            Id = 1,
            Name = "Flat",
            Adress = "244-5082 Laoreet Road",
            OwnerId = 66
        },
        new Unit{
            Id = 2,
            Name = "House",
            Adress = "P.O. Box 318, 5196 Vitae, Avenue",
            OwnerId = 7
        },
        new Unit{
            Id = 3,
            Name = "Flat",
            Adress = "915-2457 Fringilla, St.",
            OwnerId = 86
        },
        new Unit{
            Id = 4,
            Name = "Flat",
            Adress = "Ap #784-4359 Eleifend, Rd.",
            OwnerId = 2
        },
        new Unit{
            Id = 5,
            Name = "House",
            Adress = "251-6877 Nulla. Rd.",
            OwnerId = 80
        },
        new Unit{
            Id = 6,
            Name = "House",
            Adress = "796-9643 Ornare. Av.",
            OwnerId = 45
        },
        new Unit{
            Id = 7,
            Name = "Flat",
            Adress = "Ap #438-1332 Sociis Av.",
            OwnerId = 99
        },
        new Unit{
            Id = 8,
            Name = "Flat",
            Adress = "P.O. Box 409, 7852 Condimentum. Av.",
            OwnerId = 91
        },
        new Unit{
            Id = 9,
            Name = "House",
            Adress = "Ap #425-938 Suspendisse Avenue",
            OwnerId = 89
        },
        new Unit{
            Id = 10,
            Name = "Flat",
            Adress = "P.O. Box 763, 8086 Accumsan Av.",
            OwnerId = 34
        },
        new Unit{
            Id = 11,
            Name = "Flat",
            Adress = "P.O. Box 384, 6592 Duis Ave",
            OwnerId = 85
        },
        new Unit{
            Id = 12,
            Name = "House",
            Adress = "Ap #897-9347 Cum St.",
            OwnerId = 87
        },
        new Unit{
            Id = 13,
            Name = "House",
            Adress = "7412 Nisi Rd.",
            OwnerId = 96
        },
        new Unit{
            Id = 14,
            Name = "Flat",
            Adress = "288-7984 Donec Road",
            OwnerId = 58
        },
        new Unit{
            Id = 15,
            Name = "Flat",
            Adress = "P.O. Box 239, 410 Facilisis Rd.",
            OwnerId = 37
        },
        new Unit{
            Id = 16,
            Name = "House",
            Adress = "8178 Porttitor St.",
            OwnerId = 76
        },
        new Unit{
            Id = 17,
            Name = "Flat",
            Adress = "994-8010 Placerat, St.",
            OwnerId = 49
        },
        new Unit{
            Id = 18,
            Name = "Flat",
            Adress = "P.O. Box 501, 6891 Elit, St.",
            OwnerId = 98
        },
        new Unit{
            Id = 19,
            Name = "Flat",
            Adress = "Ap #695-1667 Pellentesque St.",
            OwnerId = 52
        },
        new Unit{
            Id = 20,
            Name = "House",
            Adress = "Ap #635-4757 Amet Rd.",
            OwnerId = 49
        },
        new Unit{
            Id = 21,
            Name = "Flat",
            Adress = "Ap #506-6090 Semper Av.",
            OwnerId = 49
        },
        new Unit{
            Id = 22,
            Name = "Flat",
            Adress = "Ap #206-7307 Aliquam St.",
            OwnerId = 55
        },
        new Unit{
            Id = 23,
            Name = "Flat",
            Adress = "Ap #134-3459 Nec, Road",
            OwnerId = 78
        },
        new Unit{
            Id = 24,
            Name = "House",
            Adress = "P.O. Box 907, 2206 Placerat Rd.",
            OwnerId = 8
        },
        new Unit{
            Id = 25,
            Name = "Flat",
            Adress = "228-6958 Ullamcorper Rd.",
            OwnerId = 51
        },
        new Unit{
            Id = 26,
            Name = "Flat",
            Adress = "1642 Tempus Street",
            OwnerId = 25
        },
        new Unit{
            Id = 27,
            Name = "House",
            Adress = "856-2130 Sed Rd.",
            OwnerId = 29
        },
        new Unit{
            Id = 28,
            Name = "House",
            Adress = "Ap #869-5786 Euismod St.",
            OwnerId = 29
        },
        new Unit{
            Id = 29,
            Name = "Flat",
            Adress = "498-2595 Donec St.",
            OwnerId = 79
        },
        new Unit{
            Id = 30,
            Name = "House",
            Adress = "P.O. Box 736, 139 Ac, Ave",
            OwnerId = 20
        },
        new Unit{
            Id = 31,
            Name = "Flat",
            Adress = "736-5508 Lacinia Street",
            OwnerId = 52
        },
        new Unit{
            Id = 32,
            Name = "House",
            Adress = "Ap #207-2831 Malesuada. Avenue",
            OwnerId = 31
        },
        new Unit{
            Id = 33,
            Name = "House",
            Adress = "Ap #801-8736 At, Street",
            OwnerId = 74
        },
        new Unit{
            Id = 34,
            Name = "House",
            Adress = "Ap #841-8198 Purus Av.",
            OwnerId = 91
        },
        new Unit{
            Id = 35,
            Name = "House",
            Adress = "4730 Ullamcorper, Street",
            OwnerId = 4
        },
        new Unit{
            Id = 36,
            Name = "Flat",
            Adress = "173-2332 Ac Rd.",
            OwnerId = 47
        },
        new Unit{
            Id = 37,
            Name = "Flat",
            Adress = "3800 Et Avenue",
            OwnerId = 21
        },
        new Unit{
            Id = 38,
            Name = "Flat",
            Adress = "Ap #418-9833 Suspendisse St.",
            OwnerId = 89
        },
        new Unit{
            Id = 39,
            Name = "Flat",
            Adress = "824-2881 Quis, Street",
            OwnerId = 39
        },
        new Unit{
            Id = 40,
            Name = "Flat",
            Adress = "P.O. Box 675, 9229 Blandit. Street",
            OwnerId = 24
        },
        new Unit{
            Id = 41,
            Name = "Flat",
            Adress = "659-5369 Ornare, Ave",
            OwnerId = 55
        },
        new Unit{
            Id = 42,
            Name = "Flat",
            Adress = "619-649 At, St.",
            OwnerId = 75
        },
        new Unit{
            Id = 43,
            Name = "Flat",
            Adress = "122-9114 Donec St.",
            OwnerId = 20
        },
        new Unit{
            Id = 44,
            Name = "Flat",
            Adress = "Ap #663-7238 Vitae Rd.",
            OwnerId = 1
        },
        new Unit{
            Id = 45,
            Name = "House",
            Adress = "8488 Etiam St.",
            OwnerId = 40
        },
        new Unit{
            Id = 46,
            Name = "Flat",
            Adress = "Ap #185-737 Luctus. Avenue",
            OwnerId = 54
        },
        new Unit{
            Id = 47,
            Name = "House",
            Adress = "815-2558 Turpis. St.",
            OwnerId = 47
        },
        new Unit{
            Id = 48,
            Name = "Flat",
            Adress = "Ap #381-971 Lorem, Street",
            OwnerId = 7
        },
        new Unit{
            Id = 49,
            Name = "Flat",
            Adress = "735-919 Feugiat Street",
            OwnerId = 27
        },
        new Unit{
            Id = 50,
            Name = "Flat",
            Adress = "229-8447 Malesuada St.",
            OwnerId = 55
        },
        new Unit{
            Id = 51,
            Name = "House",
            Adress = "120-9930 Eget Rd.",
            OwnerId = 7
        },
        new Unit{
            Id = 52,
            Name = "House",
            Adress = "5731 Dictum. Avenue",
            OwnerId = 3
        },
        new Unit{
            Id = 53,
            Name = "Flat",
            Adress = "Ap #428-1425 Mi Ave",
            OwnerId = 82
        },
        new Unit{
            Id = 54,
            Name = "House",
            Adress = "8849 Mollis. Rd.",
            OwnerId = 21
        },
        new Unit{
            Id = 55,
            Name = "House",
            Adress = "758-1882 Elit, Rd.",
            OwnerId = 2
        },
        new Unit{
            Id = 56,
            Name = "Flat",
            Adress = "390-7234 A, Ave",
            OwnerId = 60
        },
        new Unit{
            Id = 57,
            Name = "House",
            Adress = "Ap #825-9121 Enim Rd.",
            OwnerId = 16
        },
        new Unit{
            Id = 58,
            Name = "Flat",
            Adress = "P.O. Box 211, 7222 At Rd.",
            OwnerId = 80
        },
        new Unit{
            Id = 59,
            Name = "House",
            Adress = "Ap #227-4975 Urna Road",
            OwnerId = 13
        },
        new Unit{
            Id = 60,
            Name = "House",
            Adress = "P.O. Box 483, 125 Et, Road",
            OwnerId = 62
        },
        new Unit{
            Id = 61,
            Name = "Flat",
            Adress = "Ap #929-4837 Quam Rd.",
            OwnerId = 2
        },
        new Unit{
            Id = 62,
            Name = "House",
            Adress = "Ap #627-3066 Ornare Road",
            OwnerId = 77
        },
        new Unit{
            Id = 63,
            Name = "House",
            Adress = "144-4151 Ipsum Road",
            OwnerId = 6
        },
        new Unit{
            Id = 64,
            Name = "House",
            Adress = "763-3510 Vitae St.",
            OwnerId = 86
        },
        new Unit{
            Id = 65,
            Name = "House",
            Adress = "Ap #497-3442 Pede. St.",
            OwnerId = 18
        },
        new Unit{
            Id = 66,
            Name = "House",
            Adress = "422 Risus, St.",
            OwnerId = 16
        },
        new Unit{
            Id = 67,
            Name = "House",
            Adress = "429-574 Cursus Avenue",
            OwnerId = 68
        },
        new Unit{
            Id = 68,
            Name = "Flat",
            Adress = "965-6015 Nulla Rd.",
            OwnerId = 51
        },
        new Unit{
            Id = 69,
            Name = "Flat",
            Adress = "835-3720 Porttitor Road",
            OwnerId = 51
        },
        new Unit{
            Id = 70,
            Name = "House",
            Adress = "401-5030 Curabitur Road",
            OwnerId = 8
        },
        new Unit{
            Id = 71,
            Name = "House",
            Adress = "Ap #767-6653 Quis, Road",
            OwnerId = 93
        },
        new Unit{
            Id = 72,
            Name = "House",
            Adress = "974-4099 Pulvinar Rd.",
            OwnerId = 69
        },
        new Unit{
            Id = 73,
            Name = "House",
            Adress = "Ap #925-599 Non Road",
            OwnerId = 83
        },
        new Unit{
            Id = 74,
            Name = "Flat",
            Adress = "4257 Aptent Ave",
            OwnerId = 40
        },
        new Unit{
            Id = 75,
            Name = "Flat",
            Adress = "783-8894 Nunc Rd.",
            OwnerId = 78
        },
        new Unit{
            Id = 76,
            Name = "Flat",
            Adress = "Ap #502-9285 Ullamcorper, St.",
            OwnerId = 96
        },
        new Unit{
            Id = 77,
            Name = "Flat",
            Adress = "527-3770 A, Avenue",
            OwnerId = 69
        },
        new Unit{
            Id = 78,
            Name = "House",
            Adress = "261-2809 Aliquam Street",
            OwnerId = 52
        },
        new Unit{
            Id = 79,
            Name = "House",
            Adress = "Ap #758-3209 Et, St.",
            OwnerId = 56
        },
        new Unit{
            Id = 80,
            Name = "Flat",
            Adress = "205-6388 Varius. Rd.",
            OwnerId = 23
        },
        new Unit{
            Id = 81,
            Name = "Flat",
            Adress = "523-8890 Lectus Road",
            OwnerId = 22
        },
        new Unit{
            Id = 82,
            Name = "House",
            Adress = "P.O. Box 950, 441 Fringilla Av.",
            OwnerId = 57
        },
        new Unit{
            Id = 83,
            Name = "House",
            Adress = "P.O. Box 407, 5307 Vitae Av.",
            OwnerId = 68
        },
        new Unit{
            Id = 84,
            Name = "Flat",
            Adress = "997-8349 Dolor. Ave",
            OwnerId = 4
        },
        new Unit{
            Id = 85,
            Name = "Flat",
            Adress = "Ap #806-394 Faucibus St.",
            OwnerId = 66
        },
        new Unit{
            Id = 86,
            Name = "Flat",
            Adress = "Ap #460-6358 Dui Rd.",
            OwnerId = 58
        },
        new Unit{
            Id = 87,
            Name = "Flat",
            Adress = "Ap #912-8079 Ullamcorper Avenue",
            OwnerId = 7
        },
        new Unit{
            Id = 88,
            Name = "House",
            Adress = "6088 Vitae, Road",
            OwnerId = 6
        },
        new Unit{
            Id = 89,
            Name = "Flat",
            Adress = "4728 Fusce Road",
            OwnerId = 64
        },
        new Unit{
            Id = 90,
            Name = "House",
            Adress = "354-6674 Mollis. Ave",
            OwnerId = 72
        },
        new Unit{
            Id = 91,
            Name = "House",
            Adress = "Ap #428-2494 Mi, Avenue",
            OwnerId = 3
        },
        new Unit{
            Id = 92,
            Name = "Flat",
            Adress = "Ap #707-3091 Sed Avenue",
            OwnerId = 50
        },
        new Unit{
            Id = 93,
            Name = "Flat",
            Adress = "Ap #221-7573 Diam Av.",
            OwnerId = 5
        },
        new Unit{
            Id = 94,
            Name = "Flat",
            Adress = "7873 Et St.",
            OwnerId = 36
        },
        new Unit{
            Id = 95,
            Name = "House",
            Adress = "3417 Id St.",
            OwnerId = 88
        },
        new Unit{
            Id = 96,
            Name = "House",
            Adress = "122-1917 Sed Ave",
            OwnerId = 61
        },
        new Unit{
            Id = 97,
            Name = "Flat",
            Adress = "Ap #504-6981 Semper St.",
            OwnerId = 5
        },
        new Unit{
            Id = 98,
            Name = "Flat",
            Adress = "Ap #438-3351 Et, Av.",
            OwnerId = 7
        },
        new Unit{
            Id = 99,
            Name = "House",
            Adress = "Ap #477-6848 Tincidunt Rd.",
            OwnerId = 2
        },
        new Unit{
            Id = 100,
            Name = "Flat",
            Adress = "P.O. Box 430, 320 Sodales. Rd.",
            OwnerId = 42
        },
        new Unit{
            Id = 101,
            Name = "House",
            Adress = "854-8517 Ultrices, St.",
            OwnerId = 9
        },
        new Unit{
            Id = 102,
            Name = "House",
            Adress = "788-4111 Mollis Avenue",
            OwnerId = 17
        },
        new Unit{
            Id = 103,
            Name = "House",
            Adress = "P.O. Box 587, 1674 Scelerisque Road",
            OwnerId = 39
        },
        new Unit{
            Id = 104,
            Name = "Flat",
            Adress = "P.O. Box 587, 6757 Turpis Rd.",
            OwnerId = 38
        },
        new Unit{
            Id = 105,
            Name = "House",
            Adress = "Ap #963-5231 Aliquam Ave",
            OwnerId = 11
        },
        new Unit{
            Id = 106,
            Name = "House",
            Adress = "312-5498 Aenean Av.",
            OwnerId = 82
        },
        new Unit{
            Id = 107,
            Name = "House",
            Adress = "163-6116 Ultrices Street",
            OwnerId = 90
        },
        new Unit{
            Id = 108,
            Name = "House",
            Adress = "595-2799 Dui. Av.",
            OwnerId = 58
        },
        new Unit{
            Id = 109,
            Name = "Flat",
            Adress = "Ap #488-4114 Sem Rd.",
            OwnerId = 98
        },
        new Unit{
            Id = 110,
            Name = "House",
            Adress = "Ap #316-6972 Inceptos Avenue",
            OwnerId = 53
        },
        new Unit{
            Id = 111,
            Name = "House",
            Adress = "122-5047 Mollis. Avenue",
            OwnerId = 87
        },
        new Unit{
            Id = 112,
            Name = "Flat",
            Adress = "4132 Semper St.",
            OwnerId = 13
        },
        new Unit{
            Id = 113,
            Name = "House",
            Adress = "582-992 Vitae Road",
            OwnerId = 83
        },
        new Unit{
            Id = 114,
            Name = "House",
            Adress = "8661 Donec Street",
            OwnerId = 72
        },
        new Unit{
            Id = 115,
            Name = "House",
            Adress = "916-1388 Egestas. St.",
            OwnerId = 39
        },
        new Unit{
            Id = 116,
            Name = "Flat",
            Adress = "Ap #510-3513 Scelerisque Street",
            OwnerId = 86
        },
        new Unit{
            Id = 117,
            Name = "Flat",
            Adress = "403-8318 Interdum. Avenue",
            OwnerId = 44
        },
        new Unit{
            Id = 118,
            Name = "House",
            Adress = "245-9566 Justo Road",
            OwnerId = 51
        },
        new Unit{
            Id = 119,
            Name = "Flat",
            Adress = "451-4905 Phasellus Street",
            OwnerId = 81
        },
        new Unit{
            Id = 120,
            Name = "Flat",
            Adress = "P.O. Box 737, 7634 Phasellus Rd.",
            OwnerId = 95
        },
        new Unit{
            Id = 121,
            Name = "House",
            Adress = "668-3326 Diam. St.",
            OwnerId = 38
        },
        new Unit{
            Id = 122,
            Name = "Flat",
            Adress = "P.O. Box 955, 1658 Aliquam Avenue",
            OwnerId = 47
        },
        new Unit{
            Id = 123,
            Name = "Flat",
            Adress = "P.O. Box 826, 9895 Ante St.",
            OwnerId = 52
        },
        new Unit{
            Id = 124,
            Name = "Flat",
            Adress = "312-5335 Malesuada St.",
            OwnerId = 34
        },
        new Unit{
            Id = 125,
            Name = "House",
            Adress = "5851 A Ave",
            OwnerId = 38
        },
        new Unit{
            Id = 126,
            Name = "House",
            Adress = "Ap #326-4482 Nec Street",
            OwnerId = 32
        },
        new Unit{
            Id = 127,
            Name = "Flat",
            Adress = "Ap #400-5778 Purus, Road",
            OwnerId = 70
        },
        new Unit{
            Id = 128,
            Name = "House",
            Adress = "P.O. Box 677, 2207 Malesuada Rd.",
            OwnerId = 94
        },
        new Unit{
            Id = 129,
            Name = "Flat",
            Adress = "P.O. Box 457, 7945 Egestas St.",
            OwnerId = 69
        },
        new Unit{
            Id = 130,
            Name = "House",
            Adress = "594-3869 Augue. Rd.",
            OwnerId = 28
        },
        new Unit{
            Id = 131,
            Name = "House",
            Adress = "162-3856 Mauris Street",
            OwnerId = 68
        },
        new Unit{
            Id = 132,
            Name = "Flat",
            Adress = "Ap #704-3142 Phasellus Av.",
            OwnerId = 26
        },
        new Unit{
            Id = 133,
            Name = "Flat",
            Adress = "P.O. Box 214, 3927 Duis Avenue",
            OwnerId = 68
        },
        new Unit{
            Id = 134,
            Name = "House",
            Adress = "8981 Non, Road",
            OwnerId = 37
        },
        new Unit{
            Id = 135,
            Name = "Flat",
            Adress = "242-1718 Tristique Rd.",
            OwnerId = 42
        },
        new Unit{
            Id = 136,
            Name = "Flat",
            Adress = "9244 Velit. Ave",
            OwnerId = 76
        },
        new Unit{
            Id = 137,
            Name = "House",
            Adress = "Ap #673-7010 Fusce Av.",
            OwnerId = 99
        },
        new Unit{
            Id = 138,
            Name = "Flat",
            Adress = "1373 Bibendum Street",
            OwnerId = 24
        },
        new Unit{
            Id = 139,
            Name = "House",
            Adress = "383-408 Velit Street",
            OwnerId = 66
        },
        new Unit{
            Id = 140,
            Name = "Flat",
            Adress = "Ap #251-3571 Et, Rd.",
            OwnerId = 49
        },
        new Unit{
            Id = 141,
            Name = "House",
            Adress = "7426 Venenatis St.",
            OwnerId = 50
        },
        new Unit{
            Id = 142,
            Name = "House",
            Adress = "553-3971 Sit Rd.",
            OwnerId = 7
        },
        new Unit{
            Id = 143,
            Name = "Flat",
            Adress = "2039 Enim Avenue",
            OwnerId = 88
        },
        new Unit{
            Id = 144,
            Name = "Flat",
            Adress = "Ap #380-5571 Lectus Road",
            OwnerId = 51
        },
        new Unit{
            Id = 145,
            Name = "Flat",
            Adress = "Ap #254-7717 Integer St.",
            OwnerId = 7
        },
        new Unit{
            Id = 146,
            Name = "House",
            Adress = "Ap #555-2857 Cursus Av.",
            OwnerId = 5
        },
        new Unit{
            Id = 147,
            Name = "House",
            Adress = "434-349 Sed Rd.",
            OwnerId = 9
        },
        new Unit{
            Id = 148,
            Name = "House",
            Adress = "P.O. Box 640, 6166 Integer St.",
            OwnerId = 97
        },
        new Unit{
            Id = 149,
            Name = "House",
            Adress = "P.O. Box 576, 6213 Sed Rd.",
            OwnerId = 3
        },
        new Unit{
            Id = 150,
            Name = "Flat",
            Adress = "5284 Eu St.",
            OwnerId = 86
        },
        new Unit{
            Id = 151,
            Name = "House",
            Adress = "P.O. Box 353, 9059 Nunc Rd.",
            OwnerId = 64
        },
        new Unit{
            Id = 152,
            Name = "Flat",
            Adress = "365-7602 Donec Rd.",
            OwnerId = 96
        },
        new Unit{
            Id = 153,
            Name = "House",
            Adress = "P.O. Box 864, 2285 Aliquet Av.",
            OwnerId = 45
        },
        new Unit{
            Id = 154,
            Name = "Flat",
            Adress = "P.O. Box 158, 194 Nunc Avenue",
            OwnerId = 95
        },
        new Unit{
            Id = 155,
            Name = "House",
            Adress = "3785 Eleifend. St.",
            OwnerId = 11
        },
        new Unit{
            Id = 156,
            Name = "Flat",
            Adress = "997-5834 Duis Avenue",
            OwnerId = 43
        },
        new Unit{
            Id = 157,
            Name = "Flat",
            Adress = "P.O. Box 263, 259 Eget Rd.",
            OwnerId = 19
        },
        new Unit{
            Id = 158,
            Name = "Flat",
            Adress = "151-770 Velit Av.",
            OwnerId = 31
        },
        new Unit{
            Id = 159,
            Name = "Flat",
            Adress = "3038 Risus. Rd.",
            OwnerId = 99
        },
        new Unit{
            Id = 160,
            Name = "Flat",
            Adress = "209-2252 Imperdiet, Av.",
            OwnerId = 44
        },
        new Unit{
            Id = 161,
            Name = "Flat",
            Adress = "Ap #434-2926 Et Rd.",
            OwnerId = 23
        },
        new Unit{
            Id = 162,
            Name = "Flat",
            Adress = "566-4465 Neque. Rd.",
            OwnerId = 92
        },
        new Unit{
            Id = 163,
            Name = "Flat",
            Adress = "595-4119 Nisi. St.",
            OwnerId = 26
        },
        new Unit{
            Id = 164,
            Name = "House",
            Adress = "323-3770 Erat. Street",
            OwnerId = 91
        },
        new Unit{
            Id = 165,
            Name = "House",
            Adress = "3049 Cursus Road",
            OwnerId = 28
        },
        new Unit{
            Id = 166,
            Name = "Flat",
            Adress = "143-1695 Conubia Av.",
            OwnerId = 84
        },
        new Unit{
            Id = 167,
            Name = "Flat",
            Adress = "P.O. Box 878, 9992 Id, Rd.",
            OwnerId = 25
        },
        new Unit{
            Id = 168,
            Name = "Flat",
            Adress = "572-7271 Adipiscing, Road",
            OwnerId = 31
        },
        new Unit{
            Id = 169,
            Name = "Flat",
            Adress = "Ap #922-9485 Porta St.",
            OwnerId = 66
        },
        new Unit{
            Id = 170,
            Name = "Flat",
            Adress = "P.O. Box 236, 1414 Semper St.",
            OwnerId = 46
        },
        new Unit{
            Id = 171,
            Name = "Flat",
            Adress = "756-357 Felis Street",
            OwnerId = 78
        },
        new Unit{
            Id = 172,
            Name = "Flat",
            Adress = "P.O. Box 829, 2103 Ut St.",
            OwnerId = 70
        },
        new Unit{
            Id = 173,
            Name = "Flat",
            Adress = "9822 Parturient Street",
            OwnerId = 10
        },
        new Unit{
            Id = 174,
            Name = "House",
            Adress = "P.O. Box 883, 6186 Eget Ave",
            OwnerId = 39
        },
        new Unit{
            Id = 175,
            Name = "House",
            Adress = "P.O. Box 379, 1144 A, St.",
            OwnerId = 97
        },
        new Unit{
            Id = 176,
            Name = "Flat",
            Adress = "Ap #224-965 Vitae Avenue",
            OwnerId = 61
        },
        new Unit{
            Id = 177,
            Name = "Flat",
            Adress = "3128 Hendrerit. St.",
            OwnerId = 48
        },
        new Unit{
            Id = 178,
            Name = "House",
            Adress = "Ap #256-2463 Dui Av.",
            OwnerId = 45
        },
        new Unit{
            Id = 179,
            Name = "House",
            Adress = "Ap #911-2279 Velit. Rd.",
            OwnerId = 67
        },
        new Unit{
            Id = 180,
            Name = "House",
            Adress = "Ap #650-9656 Risus. St.",
            OwnerId = 93
        },
        new Unit{
            Id = 181,
            Name = "Flat",
            Adress = "Ap #328-3676 Tortor Rd.",
            OwnerId = 86
        },
        new Unit{
            Id = 182,
            Name = "Flat",
            Adress = "661-5517 Nec, St.",
            OwnerId = 23
        },
        new Unit{
            Id = 183,
            Name = "House",
            Adress = "150-9573 Nullam Road",
            OwnerId = 83
        },
        new Unit{
            Id = 184,
            Name = "Flat",
            Adress = "604-8905 Ullamcorper Ave",
            OwnerId = 86
        },
        new Unit{
            Id = 185,
            Name = "Flat",
            Adress = "P.O. Box 795, 2409 Aliquam Avenue",
            OwnerId = 88
        },
        new Unit{
            Id = 186,
            Name = "House",
            Adress = "Ap #254-3649 Duis St.",
            OwnerId = 24
        },
        new Unit{
            Id = 187,
            Name = "Flat",
            Adress = "Ap #315-8225 Sit Avenue",
            OwnerId = 4
        },
        new Unit{
            Id = 188,
            Name = "Flat",
            Adress = "677-7473 Sociis Ave",
            OwnerId = 16
        },
        new Unit{
            Id = 189,
            Name = "House",
            Adress = "Ap #127-3064 Eu, Avenue",
            OwnerId = 41
        },
        new Unit{
            Id = 190,
            Name = "House",
            Adress = "Ap #990-3768 Ipsum Ave",
            OwnerId = 51
        },
        new Unit{
            Id = 191,
            Name = "Flat",
            Adress = "112-9890 Maecenas Road",
            OwnerId = 90
        },
        new Unit{
            Id = 192,
            Name = "House",
            Adress = "Ap #698-7395 Morbi Rd.",
            OwnerId = 5
        },
        new Unit{
            Id = 193,
            Name = "Flat",
            Adress = "P.O. Box 601, 6632 Ut Street",
            OwnerId = 75
        },
        new Unit{
            Id = 194,
            Name = "House",
            Adress = "P.O. Box 581, 6298 Est Road",
            OwnerId = 16
        },
        new Unit{
            Id = 195,
            Name = "Flat",
            Adress = "Ap #449-7523 Arcu. Rd.",
            OwnerId = 62
        },
        new Unit{
            Id = 196,
            Name = "Flat",
            Adress = "416-9830 Aliquam Ave",
            OwnerId = 52
        },
        new Unit{
            Id = 197,
            Name = "Flat",
            Adress = "815-2821 Eu St.",
            OwnerId = 99
        },
        new Unit{
            Id = 198,
            Name = "Flat",
            Adress = "3898 Fringilla St.",
            OwnerId = 31
        },
        new Unit{
            Id = 199,
            Name = "Flat",
            Adress = "551-5696 Egestas. Avenue",
            OwnerId = 4
        },
        new Unit{
            Id = 200,
            Name = "House",
            Adress = "Ap #173-4291 Enim Ave",
            OwnerId = 4
        }
    };
        public void Seeding(EntityTypeBuilder<Unit> builder) => builder.HasData(units);
    }
}
