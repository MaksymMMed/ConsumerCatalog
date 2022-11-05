using DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeding
{
    public class EnergyConsumeSeeder : ISeeder<EnergyConsume>
    {
        private static readonly List<EnergyConsume> energyConsume = new()
        {
    new EnergyConsume{
        Id = 1,
        SizeDay = 485,
        SizeNight = 339,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 1
    },
    new EnergyConsume{
        Id = 2,
        SizeDay = 343,
        SizeNight = 310,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 2
    },
    new EnergyConsume{
        Id = 3,
        SizeDay = 705,
        SizeNight = 386,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 3
    },
    new EnergyConsume{
        Id = 4,
        SizeDay = 467,
        SizeNight = 320,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 4
    },
    new EnergyConsume{
        Id = 5,
        SizeDay = 703,
        SizeNight = 470,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 5
    },
    new EnergyConsume{
        Id = 6,
        SizeDay = 553,
        SizeNight = 405,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 6
    },
    new EnergyConsume{
        Id = 7,
        SizeDay = 467,
        SizeNight = 488,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 7
    },
    new EnergyConsume{
        Id = 8,
        SizeDay = 511,
        SizeNight = 487,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 8
    },
    new EnergyConsume{
        Id = 9,
        SizeDay = 709,
        SizeNight = 439,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 9
    },
    new EnergyConsume{
        Id = 10,
        SizeDay = 439,
        SizeNight = 395,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 10
    },
    new EnergyConsume{
        Id = 11,
        SizeDay = 318,
        SizeNight = 450,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 11
    },
    new EnergyConsume{
        Id = 12,
        SizeDay = 483,
        SizeNight = 415,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 12
    },
    new EnergyConsume{
        Id = 13,
        SizeDay = 584,
        SizeNight = 336,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 13
    },
    new EnergyConsume{
        Id = 14,
        SizeDay = 661,
        SizeNight = 305,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 14
    },
    new EnergyConsume{
        Id = 15,
        SizeDay = 773,
        SizeNight = 224,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 15
    },
    new EnergyConsume{
        Id = 16,
        SizeDay = 416,
        SizeNight = 368,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 16
    },
    new EnergyConsume{
        Id = 17,
        SizeDay = 789,
        SizeNight = 158,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 17
    },
    new EnergyConsume{
        Id = 18,
        SizeDay = 686,
        SizeNight = 267,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 18
    },
    new EnergyConsume{
        Id = 19,
        SizeDay = 704,
        SizeNight = 298,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 19
    },
    new EnergyConsume{
        Id = 20,
        SizeDay = 384,
        SizeNight = 219,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 20
    },
    new EnergyConsume{
        Id = 21,
        SizeDay = 407,
        SizeNight = 249,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 21
    },
    new EnergyConsume{
        Id = 22,
        SizeDay = 600,
        SizeNight = 272,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 22
    },
    new EnergyConsume{
        Id = 23,
        SizeDay = 499,
        SizeNight = 400,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 23
    },
    new EnergyConsume{
        Id = 24,
        SizeDay = 787,
        SizeNight = 352,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 24
    },
    new EnergyConsume{
        Id = 25,
        SizeDay = 772,
        SizeNight = 172,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 25
    },
    new EnergyConsume{
        Id = 26,
        SizeDay = 474,
        SizeNight = 273,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 26
    },
    new EnergyConsume{
        Id = 27,
        SizeDay = 545,
        SizeNight = 369,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 27
    },
    new EnergyConsume{
        Id = 28,
        SizeDay = 511,
        SizeNight = 326,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 28
    },
    new EnergyConsume{
        Id = 29,
        SizeDay = 274,
        SizeNight = 480,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 29
    },
    new EnergyConsume{
        Id = 30,
        SizeDay = 697,
        SizeNight = 164,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 30
    },
    new EnergyConsume{
        Id = 31,
        SizeDay = 732,
        SizeNight = 460,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 31
    },
    new EnergyConsume{
        Id = 32,
        SizeDay = 313,
        SizeNight = 369,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 32
    },
    new EnergyConsume{
        Id = 33,
        SizeDay = 522,
        SizeNight = 450,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 33
    },
    new EnergyConsume{
        Id = 34,
        SizeDay = 250,
        SizeNight = 488,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 34
    },
    new EnergyConsume{
        Id = 35,
        SizeDay = 648,
        SizeNight = 267,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 35
    },
    new EnergyConsume{
        Id = 36,
        SizeDay = 718,
        SizeNight = 269,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 36
    },
    new EnergyConsume{
        Id = 37,
        SizeDay = 459,
        SizeNight = 448,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 37
    },
    new EnergyConsume{
        Id = 38,
        SizeDay = 776,
        SizeNight = 199,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 38
    },
    new EnergyConsume{
        Id = 39,
        SizeDay = 322,
        SizeNight = 362,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 39
    },
    new EnergyConsume{
        Id = 40,
        SizeDay = 419,
        SizeNight = 222,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 40
    },
    new EnergyConsume{
        Id = 41,
        SizeDay = 576,
        SizeNight = 340,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 41
    },
    new EnergyConsume{
        Id = 42,
        SizeDay = 310,
        SizeNight = 208,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 42
    },
    new EnergyConsume{
        Id = 43,
        SizeDay = 415,
        SizeNight = 321,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 43
    },
    new EnergyConsume{
        Id = 44,
        SizeDay = 755,
        SizeNight = 349,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 44
    },
    new EnergyConsume{
        Id = 45,
        SizeDay = 570,
        SizeNight = 273,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 45
    },
    new EnergyConsume{
        Id = 46,
        SizeDay = 559,
        SizeNight = 215,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 46
    },
    new EnergyConsume{
        Id = 47,
        SizeDay = 522,
        SizeNight = 172,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 47
    },
    new EnergyConsume{
        Id = 48,
        SizeDay = 671,
        SizeNight = 169,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 48
    },
    new EnergyConsume{
        Id = 49,
        SizeDay = 348,
        SizeNight = 322,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 49
    },
    new EnergyConsume{
        Id = 50,
        SizeDay = 388,
        SizeNight = 403,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 50
    },
    new EnergyConsume{
        Id = 51,
        SizeDay = 511,
        SizeNight = 352,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 51
    },
    new EnergyConsume{
        Id = 52,
        SizeDay = 700,
        SizeNight = 353,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 52
    },
    new EnergyConsume{
        Id = 53,
        SizeDay = 402,
        SizeNight = 359,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 53
    },
    new EnergyConsume{
        Id = 54,
        SizeDay = 308,
        SizeNight = 361,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 54
    },
    new EnergyConsume{
        Id = 55,
        SizeDay = 584,
        SizeNight = 387,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 55
    },
    new EnergyConsume{
        Id = 56,
        SizeDay = 628,
        SizeNight = 204,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 56
    },
    new EnergyConsume{
        Id = 57,
        SizeDay = 422,
        SizeNight = 287,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 57
    },
    new EnergyConsume{
        Id = 58,
        SizeDay = 507,
        SizeNight = 291,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 58
    },
    new EnergyConsume{
        Id = 59,
        SizeDay = 649,
        SizeNight = 326,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 59
    },
    new EnergyConsume{
        Id = 60,
        SizeDay = 745,
        SizeNight = 340,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 60
    },
    new EnergyConsume{
        Id = 61,
        SizeDay = 655,
        SizeNight = 378,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 61
    },
    new EnergyConsume{
        Id = 62,
        SizeDay = 670,
        SizeNight = 401,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 62
    },
    new EnergyConsume{
        Id = 63,
        SizeDay = 689,
        SizeNight = 435,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 63
    },
    new EnergyConsume{
        Id = 64,
        SizeDay = 679,
        SizeNight = 289,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 64
    },
    new EnergyConsume{
        Id = 65,
        SizeDay = 345,
        SizeNight = 386,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 65
    },
    new EnergyConsume{
        Id = 66,
        SizeDay = 784,
        SizeNight = 496,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 66
    },
    new EnergyConsume{
        Id = 67,
        SizeDay = 653,
        SizeNight = 179,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 67
    },
    new EnergyConsume{
        Id = 68,
        SizeDay = 470,
        SizeNight = 437,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 68
    },
    new EnergyConsume{
        Id = 69,
        SizeDay = 411,
        SizeNight = 357,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 69
    },
    new EnergyConsume{
        Id = 70,
        SizeDay = 306,
        SizeNight = 373,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 70
    },
    new EnergyConsume{
        Id = 71,
        SizeDay = 676,
        SizeNight = 171,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 71
    },
    new EnergyConsume{
        Id = 72,
        SizeDay = 645,
        SizeNight = 230,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 72
    },
    new EnergyConsume{
        Id = 73,
        SizeDay = 648,
        SizeNight = 381,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 73
    },
    new EnergyConsume{
        Id = 74,
        SizeDay = 455,
        SizeNight = 336,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 74
    },
    new EnergyConsume{
        Id = 75,
        SizeDay = 373,
        SizeNight = 304,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 75
    },
    new EnergyConsume{
        Id = 76,
        SizeDay = 279,
        SizeNight = 163,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 76
    },
    new EnergyConsume{
        Id = 77,
        SizeDay = 729,
        SizeNight = 166,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 77
    },
    new EnergyConsume{
        Id = 78,
        SizeDay = 296,
        SizeNight = 325,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 78
    },
    new EnergyConsume{
        Id = 79,
        SizeDay = 367,
        SizeNight = 359,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 79
    },
    new EnergyConsume{
        Id = 80,
        SizeDay = 708,
        SizeNight = 289,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 80
    },
    new EnergyConsume{
        Id = 81,
        SizeDay = 681,
        SizeNight = 407,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 81
    },
    new EnergyConsume{
        Id = 82,
        SizeDay = 351,
        SizeNight = 499,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 82
    },
    new EnergyConsume{
        Id = 83,
        SizeDay = 504,
        SizeNight = 429,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 83
    },
    new EnergyConsume{
        Id = 84,
        SizeDay = 735,
        SizeNight = 371,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 84
    },
    new EnergyConsume{
        Id = 85,
        SizeDay = 549,
        SizeNight = 253,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 85
    },
    new EnergyConsume{
        Id = 86,
        SizeDay = 711,
        SizeNight = 434,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 86
    },
    new EnergyConsume{
        Id = 87,
        SizeDay = 762,
        SizeNight = 217,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 87
    },
    new EnergyConsume{
        Id = 88,
        SizeDay = 747,
        SizeNight = 333,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 88
    },
    new EnergyConsume{
        Id = 89,
        SizeDay = 452,
        SizeNight = 451,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 89
    },
    new EnergyConsume{
        Id = 90,
        SizeDay = 794,
        SizeNight = 192,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 90
    },
    new EnergyConsume{
        Id = 91,
        SizeDay = 654,
        SizeNight = 287,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 91
    },
    new EnergyConsume{
        Id = 92,
        SizeDay = 480,
        SizeNight = 418,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 92
    },
    new EnergyConsume{
        Id = 93,
        SizeDay = 284,
        SizeNight = 304,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 93
    },
    new EnergyConsume{
        Id = 94,
        SizeDay = 712,
        SizeNight = 321,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 94
    },
    new EnergyConsume{
        Id = 95,
        SizeDay = 295,
        SizeNight = 318,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 95
    },
    new EnergyConsume{
        Id = 96,
        SizeDay = 315,
        SizeNight = 373,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 96
    },
    new EnergyConsume{
        Id = 97,
        SizeDay = 265,
        SizeNight = 276,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 97
    },
    new EnergyConsume{
        Id = 98,
        SizeDay = 211,
        SizeNight = 353,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 98
    },
    new EnergyConsume{
        Id = 99,
        SizeDay = 251,
        SizeNight = 265,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 99
    },
    new EnergyConsume{
        Id = 100,
        SizeDay = 695,
        SizeNight = 382,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 100
    },
    new EnergyConsume{
        Id = 101,
        SizeDay = 609,
        SizeNight = 485,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 101
    },
    new EnergyConsume{
        Id = 102,
        SizeDay = 631,
        SizeNight = 327,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 102
    },
    new EnergyConsume{
        Id = 103,
        SizeDay = 625,
        SizeNight = 312,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 103
    },
    new EnergyConsume{
        Id = 104,
        SizeDay = 353,
        SizeNight = 245,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 104
    },
    new EnergyConsume{
        Id = 105,
        SizeDay = 672,
        SizeNight = 208,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 105
    },
    new EnergyConsume{
        Id = 106,
        SizeDay = 615,
        SizeNight = 192,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 106
    },
    new EnergyConsume{
        Id = 107,
        SizeDay = 261,
        SizeNight = 230,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 107
    },
    new EnergyConsume{
        Id = 108,
        SizeDay = 558,
        SizeNight = 326,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 108
    },
    new EnergyConsume{
        Id = 109,
        SizeDay = 783,
        SizeNight = 241,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 109
    },
    new EnergyConsume{
        Id = 110,
        SizeDay = 669,
        SizeNight = 310,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 110
    },
    new EnergyConsume{
        Id = 111,
        SizeDay = 781,
        SizeNight = 289,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 111
    },
    new EnergyConsume{
        Id = 112,
        SizeDay = 706,
        SizeNight = 174,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 112
    },
    new EnergyConsume{
        Id = 113,
        SizeDay = 672,
        SizeNight = 416,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 113
    },
    new EnergyConsume{
        Id = 114,
        SizeDay = 520,
        SizeNight = 335,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 114
    },
    new EnergyConsume{
        Id = 115,
        SizeDay = 660,
        SizeNight = 339,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 115
    },
    new EnergyConsume{
        Id = 116,
        SizeDay = 411,
        SizeNight = 419,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 116
    },
    new EnergyConsume{
        Id = 117,
        SizeDay = 433,
        SizeNight = 317,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 117
    },
    new EnergyConsume{
        Id = 118,
        SizeDay = 589,
        SizeNight = 344,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 118
    },
    new EnergyConsume{
        Id = 119,
        SizeDay = 719,
        SizeNight = 458,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 119
    },
    new EnergyConsume{
        Id = 120,
        SizeDay = 595,
        SizeNight = 198,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 120
    },
    new EnergyConsume{
        Id = 121,
        SizeDay = 440,
        SizeNight = 299,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 121
    },
    new EnergyConsume{
        Id = 122,
        SizeDay = 270,
        SizeNight = 192,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 122
    },
    new EnergyConsume{
        Id = 123,
        SizeDay = 291,
        SizeNight = 261,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 123
    },
    new EnergyConsume{
        Id = 124,
        SizeDay = 697,
        SizeNight = 220,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 124
    },
    new EnergyConsume{
        Id = 125,
        SizeDay = 736,
        SizeNight = 219,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 125
    },
    new EnergyConsume{
        Id = 126,
        SizeDay = 758,
        SizeNight = 488,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 126
    },
    new EnergyConsume{
        Id = 127,
        SizeDay = 261,
        SizeNight = 381,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 127
    },
    new EnergyConsume{
        Id = 128,
        SizeDay = 339,
        SizeNight = 288,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 128
    },
    new EnergyConsume{
        Id = 129,
        SizeDay = 538,
        SizeNight = 152,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 129
    },
    new EnergyConsume{
        Id = 130,
        SizeDay = 688,
        SizeNight = 316,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 130
    },
    new EnergyConsume{
        Id = 131,
        SizeDay = 268,
        SizeNight = 192,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 131
    },
    new EnergyConsume{
        Id = 132,
        SizeDay = 474,
        SizeNight = 252,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 132
    },
    new EnergyConsume{
        Id = 133,
        SizeDay = 512,
        SizeNight = 200,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 133
    },
    new EnergyConsume{
        Id = 134,
        SizeDay = 490,
        SizeNight = 318,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 134
    },
    new EnergyConsume{
        Id = 135,
        SizeDay = 490,
        SizeNight = 328,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 135
    },
    new EnergyConsume{
        Id = 136,
        SizeDay = 773,
        SizeNight = 376,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 136
    },
    new EnergyConsume{
        Id = 137,
        SizeDay = 225,
        SizeNight = 295,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 137
    },
    new EnergyConsume{
        Id = 138,
        SizeDay = 560,
        SizeNight = 371,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 138
    },
    new EnergyConsume{
        Id = 139,
        SizeDay = 782,
        SizeNight = 229,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 139
    },
    new EnergyConsume{
        Id = 140,
        SizeDay = 469,
        SizeNight = 182,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 140
    },
    new EnergyConsume{
        Id = 141,
        SizeDay = 679,
        SizeNight = 269,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 141
    },
    new EnergyConsume{
        Id = 142,
        SizeDay = 522,
        SizeNight = 160,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 142
    },
    new EnergyConsume{
        Id = 143,
        SizeDay = 264,
        SizeNight = 418,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 143
    },
    new EnergyConsume{
        Id = 144,
        SizeDay = 663,
        SizeNight = 268,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 144
    },
    new EnergyConsume{
        Id = 145,
        SizeDay = 783,
        SizeNight = 165,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 145
    },
    new EnergyConsume{
        Id = 146,
        SizeDay = 246,
        SizeNight = 456,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 146
    },
    new EnergyConsume{
        Id = 147,
        SizeDay = 413,
        SizeNight = 288,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 147
    },
    new EnergyConsume{
        Id = 148,
        SizeDay = 251,
        SizeNight = 167,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 148
    },
    new EnergyConsume{
        Id = 149,
        SizeDay = 543,
        SizeNight = 234,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 149
    },
    new EnergyConsume{
        Id = 150,
        SizeDay = 763,
        SizeNight = 428,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 150
    },
    new EnergyConsume{
        Id = 151,
        SizeDay = 356,
        SizeNight = 304,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 151
    },
    new EnergyConsume{
        Id = 152,
        SizeDay = 240,
        SizeNight = 437,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 152
    },
    new EnergyConsume{
        Id = 153,
        SizeDay = 546,
        SizeNight = 226,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 153
    },
    new EnergyConsume{
        Id = 154,
        SizeDay = 478,
        SizeNight = 287,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 154
    },
    new EnergyConsume{
        Id = 155,
        SizeDay = 352,
        SizeNight = 217,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 155
    },
    new EnergyConsume{
        Id = 156,
        SizeDay = 711,
        SizeNight = 309,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 156
    },
    new EnergyConsume{
        Id = 157,
        SizeDay = 537,
        SizeNight = 249,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 157
    },
    new EnergyConsume{
        Id = 158,
        SizeDay = 394,
        SizeNight = 476,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 158
    },
    new EnergyConsume{
        Id = 159,
        SizeDay = 459,
        SizeNight = 350,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 159
    },
    new EnergyConsume{
        Id = 160,
        SizeDay = 683,
        SizeNight = 386,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 160
    },
    new EnergyConsume{
        Id = 161,
        SizeDay = 207,
        SizeNight = 212,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 161
    },
    new EnergyConsume{
        Id = 162,
        SizeDay = 739,
        SizeNight = 218,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 162
    },
    new EnergyConsume{
        Id = 163,
        SizeDay = 423,
        SizeNight = 169,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 163
    },
    new EnergyConsume{
        Id = 164,
        SizeDay = 731,
        SizeNight = 356,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 164
    },
    new EnergyConsume{
        Id = 165,
        SizeDay = 591,
        SizeNight = 467,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 165
    },
    new EnergyConsume{
        Id = 166,
        SizeDay = 277,
        SizeNight = 246,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 166
    },
    new EnergyConsume{
        Id = 167,
        SizeDay = 328,
        SizeNight = 450,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 167
    },
    new EnergyConsume{
        Id = 168,
        SizeDay = 621,
        SizeNight = 352,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 168
    },
    new EnergyConsume{
        Id = 169,
        SizeDay = 747,
        SizeNight = 468,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 169
    },
    new EnergyConsume{
        Id = 170,
        SizeDay = 745,
        SizeNight = 228,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 170
    },
    new EnergyConsume{
        Id = 171,
        SizeDay = 610,
        SizeNight = 343,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 171
    },
    new EnergyConsume{
        Id = 172,
        SizeDay = 563,
        SizeNight = 159,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 172
    },
    new EnergyConsume{
        Id = 173,
        SizeDay = 474,
        SizeNight = 288,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 173
    },
    new EnergyConsume{
        Id = 174,
        SizeDay = 217,
        SizeNight = 166,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 174
    },
    new EnergyConsume{
        Id = 175,
        SizeDay = 457,
        SizeNight = 328,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 175
    },
    new EnergyConsume{
        Id = 176,
        SizeDay = 350,
        SizeNight = 292,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 176
    },
    new EnergyConsume{
        Id = 177,
        SizeDay = 694,
        SizeNight = 214,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 177
    },
    new EnergyConsume{
        Id = 178,
        SizeDay = 416,
        SizeNight = 209,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 178
    },
    new EnergyConsume{
        Id = 179,
        SizeDay = 768,
        SizeNight = 376,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 179
    },
    new EnergyConsume{
        Id = 180,
        SizeDay = 701,
        SizeNight = 216,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 180
    },
    new EnergyConsume{
        Id = 181,
        SizeDay = 309,
        SizeNight = 490,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 181
    },
    new EnergyConsume{
        Id = 182,
        SizeDay = 709,
        SizeNight = 326,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 182
    },
    new EnergyConsume{
        Id = 183,
        SizeDay = 643,
        SizeNight = 284,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 183
    },
    new EnergyConsume{
        Id = 184,
        SizeDay = 285,
        SizeNight = 342,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 184
    },
    new EnergyConsume{
        Id = 185,
        SizeDay = 752,
        SizeNight = 334,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 185
    },
    new EnergyConsume{
        Id = 186,
        SizeDay = 271,
        SizeNight = 397,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 186
    },
    new EnergyConsume{
        Id = 187,
        SizeDay = 697,
        SizeNight = 461,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 187
    },
    new EnergyConsume{
        Id = 188,
        SizeDay = 206,
        SizeNight = 394,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 188
    },
    new EnergyConsume{
        Id = 189,
        SizeDay = 745,
        SizeNight = 272,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 189
    },
    new EnergyConsume{
        Id = 190,
        SizeDay = 434,
        SizeNight = 187,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 190
    },
    new EnergyConsume{
        Id = 191,
        SizeDay = 577,
        SizeNight = 374,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 191
    },
    new EnergyConsume{
        Id = 192,
        SizeDay = 375,
        SizeNight = 155,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 192
    },
    new EnergyConsume{
        Id = 193,
        SizeDay = 418,
        SizeNight = 488,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 193
    },
    new EnergyConsume{
        Id = 194,
        SizeDay = 761,
        SizeNight = 457,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 194
    },
    new EnergyConsume{
        Id = 195,
        SizeDay = 389,
        SizeNight = 195,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 195
    },
    new EnergyConsume{
        Id = 196,
        SizeDay = 424,
        SizeNight = 209,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 196
    },
    new EnergyConsume{
        Id = 197,
        SizeDay = 645,
        SizeNight = 389,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 197
    },
    new EnergyConsume{
        Id = 198,
        SizeDay = 423,
        SizeNight = 279,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 198
    },
    new EnergyConsume{
        Id = 199,
        SizeDay = 660,
        SizeNight = 274,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 199
    },
    new EnergyConsume{
        Id = 200,
        SizeDay = 511,
        SizeNight = 253,
        Date = Convert.ToDateTime("11.04.22"),
        UnitId = 200
    },
    	new EnergyConsume{
		Id = 201,
		SizeDay = 585,
		SizeNight = 323,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 1
	},
	new EnergyConsume{
		Id = 202,
		SizeDay = 404,
		SizeNight = 352,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 2
	},
	new EnergyConsume{
		Id = 203,
		SizeDay = 401,
		SizeNight = 397,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 3
	},
	new EnergyConsume{
		Id = 204,
		SizeDay = 470,
		SizeNight = 322,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 4
	},
	new EnergyConsume{
		Id = 205,
		SizeDay = 626,
		SizeNight = 339,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 5
	},
	new EnergyConsume{
		Id = 206,
		SizeDay = 249,
		SizeNight = 306,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 6
	},
	new EnergyConsume{
		Id = 207,
		SizeDay = 460,
		SizeNight = 438,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 7
	},
	new EnergyConsume{
		Id = 208,
		SizeDay = 363,
		SizeNight = 292,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 8
	},
	new EnergyConsume{
		Id = 209,
		SizeDay = 636,
		SizeNight = 438,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 9
	},
	new EnergyConsume{
		Id = 210,
		SizeDay = 722,
		SizeNight = 389,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 10
	},
	new EnergyConsume{
		Id = 211,
		SizeDay = 235,
		SizeNight = 232,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 11
	},
	new EnergyConsume{
		Id = 212,
		SizeDay = 611,
		SizeNight = 218,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 12
	},
	new EnergyConsume{
		Id = 213,
		SizeDay = 769,
		SizeNight = 212,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 13
	},
	new EnergyConsume{
		Id = 214,
		SizeDay = 459,
		SizeNight = 417,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 14
	},
	new EnergyConsume{
		Id = 215,
		SizeDay = 276,
		SizeNight = 407,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 15
	},
	new EnergyConsume{
		Id = 216,
		SizeDay = 625,
		SizeNight = 181,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 16
	},
	new EnergyConsume{
		Id = 217,
		SizeDay = 322,
		SizeNight = 291,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 17
	},
	new EnergyConsume{
		Id = 218,
		SizeDay = 276,
		SizeNight = 466,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 18
	},
	new EnergyConsume{
		Id = 219,
		SizeDay = 628,
		SizeNight = 430,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 19
	},
	new EnergyConsume{
		Id = 220,
		SizeDay = 306,
		SizeNight = 407,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 20
	},
	new EnergyConsume{
		Id = 221,
		SizeDay = 344,
		SizeNight = 181,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 21
	},
	new EnergyConsume{
		Id = 222,
		SizeDay = 627,
		SizeNight = 218,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 22
	},
	new EnergyConsume{
		Id = 223,
		SizeDay = 791,
		SizeNight = 395,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 23
	},
	new EnergyConsume{
		Id = 224,
		SizeDay = 395,
		SizeNight = 342,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 24
	},
	new EnergyConsume{
		Id = 225,
		SizeDay = 387,
		SizeNight = 278,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 25
	},
	new EnergyConsume{
		Id = 226,
		SizeDay = 658,
		SizeNight = 450,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 26
	},
	new EnergyConsume{
		Id = 227,
		SizeDay = 379,
		SizeNight = 295,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 27
	},
	new EnergyConsume{
		Id = 228,
		SizeDay = 401,
		SizeNight = 322,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 28
	},
	new EnergyConsume{
		Id = 229,
		SizeDay = 203,
		SizeNight = 189,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 29
	},
	new EnergyConsume{
		Id = 230,
		SizeDay = 290,
		SizeNight = 451,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 30
	},
	new EnergyConsume{
		Id = 231,
		SizeDay = 719,
		SizeNight = 404,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 31
	},
	new EnergyConsume{
		Id = 232,
		SizeDay = 507,
		SizeNight = 273,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 32
	},
	new EnergyConsume{
		Id = 233,
		SizeDay = 211,
		SizeNight = 335,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 33
	},
	new EnergyConsume{
		Id = 234,
		SizeDay = 466,
		SizeNight = 325,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 34
	},
	new EnergyConsume{
		Id = 235,
		SizeDay = 746,
		SizeNight = 468,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 35
	},
	new EnergyConsume{
		Id = 236,
		SizeDay = 229,
		SizeNight = 287,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 36
	},
	new EnergyConsume{
		Id = 237,
		SizeDay = 678,
		SizeNight = 294,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 37
	},
	new EnergyConsume{
		Id = 238,
		SizeDay = 392,
		SizeNight = 322,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 38
	},
	new EnergyConsume{
		Id = 239,
		SizeDay = 343,
		SizeNight = 342,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 39
	},
	new EnergyConsume{
		Id = 240,
		SizeDay = 598,
		SizeNight = 307,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 40
	},
	new EnergyConsume{
		Id = 241,
		SizeDay = 734,
		SizeNight = 322,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 41
	},
	new EnergyConsume{
		Id = 242,
		SizeDay = 443,
		SizeNight = 348,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 42
	},
	new EnergyConsume{
		Id = 243,
		SizeDay = 374,
		SizeNight = 175,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 43
	},
	new EnergyConsume{
		Id = 244,
		SizeDay = 230,
		SizeNight = 210,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 44
	},
	new EnergyConsume{
		Id = 245,
		SizeDay = 677,
		SizeNight = 428,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 45
	},
	new EnergyConsume{
		Id = 246,
		SizeDay = 253,
		SizeNight = 351,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 46
	},
	new EnergyConsume{
		Id = 247,
		SizeDay = 688,
		SizeNight = 231,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 47
	},
	new EnergyConsume{
		Id = 248,
		SizeDay = 740,
		SizeNight = 399,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 48
	},
	new EnergyConsume{
		Id = 249,
		SizeDay = 745,
		SizeNight = 403,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 49
	},
	new EnergyConsume{
		Id = 250,
		SizeDay = 268,
		SizeNight = 316,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 50
	},
	new EnergyConsume{
		Id = 251,
		SizeDay = 642,
		SizeNight = 477,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 51
	},
	new EnergyConsume{
		Id = 252,
		SizeDay = 624,
		SizeNight = 326,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 52
	},
	new EnergyConsume{
		Id = 253,
		SizeDay = 441,
		SizeNight = 250,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 53
	},
	new EnergyConsume{
		Id = 254,
		SizeDay = 530,
		SizeNight = 414,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 54
	},
	new EnergyConsume{
		Id = 255,
		SizeDay = 746,
		SizeNight = 257,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 55
	},
	new EnergyConsume{
		Id = 256,
		SizeDay = 775,
		SizeNight = 481,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 56
	},
	new EnergyConsume{
		Id = 257,
		SizeDay = 685,
		SizeNight = 335,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 57
	},
	new EnergyConsume{
		Id = 258,
		SizeDay = 412,
		SizeNight = 307,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 58
	},
	new EnergyConsume{
		Id = 259,
		SizeDay = 521,
		SizeNight = 434,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 59
	},
	new EnergyConsume{
		Id = 260,
		SizeDay = 671,
		SizeNight = 214,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 60
	},
	new EnergyConsume{
		Id = 261,
		SizeDay = 534,
		SizeNight = 402,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 61
	},
	new EnergyConsume{
		Id = 262,
		SizeDay = 431,
		SizeNight = 427,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 62
	},
	new EnergyConsume{
		Id = 263,
		SizeDay = 308,
		SizeNight = 248,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 63
	},
	new EnergyConsume{
		Id = 264,
		SizeDay = 555,
		SizeNight = 350,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 64
	},
	new EnergyConsume{
		Id = 265,
		SizeDay = 683,
		SizeNight = 209,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 65
	},
	new EnergyConsume{
		Id = 266,
		SizeDay = 326,
		SizeNight = 429,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 66
	},
	new EnergyConsume{
		Id = 267,
		SizeDay = 728,
		SizeNight = 449,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 67
	},
	new EnergyConsume{
		Id = 268,
		SizeDay = 428,
		SizeNight = 203,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 68
	},
	new EnergyConsume{
		Id = 269,
		SizeDay = 369,
		SizeNight = 380,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 69
	},
	new EnergyConsume{
		Id = 270,
		SizeDay = 242,
		SizeNight = 302,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 70
	},
	new EnergyConsume{
		Id = 271,
		SizeDay = 227,
		SizeNight = 323,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 71
	},
	new EnergyConsume{
		Id = 272,
		SizeDay = 352,
		SizeNight = 401,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 72
	},
	new EnergyConsume{
		Id = 273,
		SizeDay = 456,
		SizeNight = 403,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 73
	},
	new EnergyConsume{
		Id = 274,
		SizeDay = 370,
		SizeNight = 163,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 74
	},
	new EnergyConsume{
		Id = 275,
		SizeDay = 304,
		SizeNight = 289,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 75
	},
	new EnergyConsume{
		Id = 276,
		SizeDay = 373,
		SizeNight = 450,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 76
	},
	new EnergyConsume{
		Id = 277,
		SizeDay = 645,
		SizeNight = 358,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 77
	},
	new EnergyConsume{
		Id = 278,
		SizeDay = 293,
		SizeNight = 206,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 78
	},
	new EnergyConsume{
		Id = 279,
		SizeDay = 439,
		SizeNight = 366,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 79
	},
	new EnergyConsume{
		Id = 280,
		SizeDay = 494,
		SizeNight = 323,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 80
	},
	new EnergyConsume{
		Id = 281,
		SizeDay = 716,
		SizeNight = 433,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 81
	},
	new EnergyConsume{
		Id = 282,
		SizeDay = 787,
		SizeNight = 228,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 82
	},
	new EnergyConsume{
		Id = 283,
		SizeDay = 561,
		SizeNight = 467,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 83
	},
	new EnergyConsume{
		Id = 284,
		SizeDay = 534,
		SizeNight = 197,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 84
	},
	new EnergyConsume{
		Id = 285,
		SizeDay = 297,
		SizeNight = 312,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 85
	},
	new EnergyConsume{
		Id = 286,
		SizeDay = 261,
		SizeNight = 185,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 86
	},
	new EnergyConsume{
		Id = 287,
		SizeDay = 595,
		SizeNight = 412,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 87
	},
	new EnergyConsume{
		Id = 288,
		SizeDay = 372,
		SizeNight = 482,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 88
	},
	new EnergyConsume{
		Id = 289,
		SizeDay = 296,
		SizeNight = 428,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 89
	},
	new EnergyConsume{
		Id = 290,
		SizeDay = 627,
		SizeNight = 166,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 90
	},
	new EnergyConsume{
		Id = 291,
		SizeDay = 535,
		SizeNight = 211,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 91
	},
	new EnergyConsume{
		Id = 292,
		SizeDay = 787,
		SizeNight = 354,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 92
	},
	new EnergyConsume{
		Id = 293,
		SizeDay = 377,
		SizeNight = 433,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 93
	},
	new EnergyConsume{
		Id = 294,
		SizeDay = 504,
		SizeNight = 238,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 94
	},
	new EnergyConsume{
		Id = 295,
		SizeDay = 405,
		SizeNight = 311,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 95
	},
	new EnergyConsume{
		Id = 296,
		SizeDay = 532,
		SizeNight = 298,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 96
	},
	new EnergyConsume{
		Id = 297,
		SizeDay = 593,
		SizeNight = 176,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 97
	},
	new EnergyConsume{
		Id = 298,
		SizeDay = 783,
		SizeNight = 453,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 98
	},
	new EnergyConsume{
		Id = 299,
		SizeDay = 761,
		SizeNight = 406,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 99
	},
	new EnergyConsume{
		Id = 300,
		SizeDay = 562,
		SizeNight = 168,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 100
	},
	new EnergyConsume{
		Id = 301,
		SizeDay = 608,
		SizeNight = 289,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 101
	},
	new EnergyConsume{
		Id = 302,
		SizeDay = 229,
		SizeNight = 431,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 102
	},
	new EnergyConsume{
		Id = 303,
		SizeDay = 640,
		SizeNight = 239,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 103
	},
	new EnergyConsume{
		Id = 304,
		SizeDay = 201,
		SizeNight = 394,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 104
	},
	new EnergyConsume{
		Id = 305,
		SizeDay = 664,
		SizeNight = 493,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 105
	},
	new EnergyConsume{
		Id = 306,
		SizeDay = 333,
		SizeNight = 324,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 106
	},
	new EnergyConsume{
		Id = 307,
		SizeDay = 771,
		SizeNight = 431,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 107
	},
	new EnergyConsume{
		Id = 308,
		SizeDay = 335,
		SizeNight = 334,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 108
	},
	new EnergyConsume{
		Id = 309,
		SizeDay = 324,
		SizeNight = 349,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 109
	},
	new EnergyConsume{
		Id = 310,
		SizeDay = 620,
		SizeNight = 321,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 110
	},
	new EnergyConsume{
		Id = 311,
		SizeDay = 781,
		SizeNight = 392,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 111
	},
	new EnergyConsume{
		Id = 312,
		SizeDay = 516,
		SizeNight = 201,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 112
	},
	new EnergyConsume{
		Id = 313,
		SizeDay = 270,
		SizeNight = 238,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 113
	},
	new EnergyConsume{
		Id = 314,
		SizeDay = 371,
		SizeNight = 248,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 114
	},
	new EnergyConsume{
		Id = 315,
		SizeDay = 695,
		SizeNight = 322,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 115
	},
	new EnergyConsume{
		Id = 316,
		SizeDay = 686,
		SizeNight = 334,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 116
	},
	new EnergyConsume{
		Id = 317,
		SizeDay = 230,
		SizeNight = 344,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 117
	},
	new EnergyConsume{
		Id = 318,
		SizeDay = 694,
		SizeNight = 432,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 118
	},
	new EnergyConsume{
		Id = 319,
		SizeDay = 786,
		SizeNight = 458,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 119
	},
	new EnergyConsume{
		Id = 320,
		SizeDay = 738,
		SizeNight = 342,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 120
	},
	new EnergyConsume{
		Id = 321,
		SizeDay = 400,
		SizeNight = 201,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 121
	},
	new EnergyConsume{
		Id = 322,
		SizeDay = 411,
		SizeNight = 358,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 122
	},
	new EnergyConsume{
		Id = 323,
		SizeDay = 347,
		SizeNight = 179,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 123
	},
	new EnergyConsume{
		Id = 324,
		SizeDay = 559,
		SizeNight = 225,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 124
	},
	new EnergyConsume{
		Id = 325,
		SizeDay = 682,
		SizeNight = 445,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 125
	},
	new EnergyConsume{
		Id = 326,
		SizeDay = 400,
		SizeNight = 406,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 126
	},
	new EnergyConsume{
		Id = 327,
		SizeDay = 787,
		SizeNight = 453,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 127
	},
	new EnergyConsume{
		Id = 328,
		SizeDay = 411,
		SizeNight = 336,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 128
	},
	new EnergyConsume{
		Id = 329,
		SizeDay = 201,
		SizeNight = 409,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 129
	},
	new EnergyConsume{
		Id = 330,
		SizeDay = 566,
		SizeNight = 151,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 130
	},
	new EnergyConsume{
		Id = 331,
		SizeDay = 362,
		SizeNight = 355,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 131
	},
	new EnergyConsume{
		Id = 332,
		SizeDay = 794,
		SizeNight = 154,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 132
	},
	new EnergyConsume{
		Id = 333,
		SizeDay = 440,
		SizeNight = 444,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 133
	},
	new EnergyConsume{
		Id = 334,
		SizeDay = 209,
		SizeNight = 214,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 134
	},
	new EnergyConsume{
		Id = 335,
		SizeDay = 704,
		SizeNight = 308,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 135
	},
	new EnergyConsume{
		Id = 336,
		SizeDay = 475,
		SizeNight = 167,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 136
	},
	new EnergyConsume{
		Id = 337,
		SizeDay = 650,
		SizeNight = 295,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 137
	},
	new EnergyConsume{
		Id = 338,
		SizeDay = 626,
		SizeNight = 418,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 138
	},
	new EnergyConsume{
		Id = 339,
		SizeDay = 251,
		SizeNight = 327,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 139
	},
	new EnergyConsume{
		Id = 340,
		SizeDay = 759,
		SizeNight = 290,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 140
	},
	new EnergyConsume{
		Id = 341,
		SizeDay = 336,
		SizeNight = 159,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 141
	},
	new EnergyConsume{
		Id = 342,
		SizeDay = 784,
		SizeNight = 403,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 142
	},
	new EnergyConsume{
		Id = 343,
		SizeDay = 392,
		SizeNight = 444,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 143
	},
	new EnergyConsume{
		Id = 344,
		SizeDay = 249,
		SizeNight = 324,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 144
	},
	new EnergyConsume{
		Id = 345,
		SizeDay = 437,
		SizeNight = 458,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 145
	},
	new EnergyConsume{
		Id = 346,
		SizeDay = 573,
		SizeNight = 268,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 146
	},
	new EnergyConsume{
		Id = 347,
		SizeDay = 587,
		SizeNight = 396,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 147
	},
	new EnergyConsume{
		Id = 348,
		SizeDay = 315,
		SizeNight = 258,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 148
	},
	new EnergyConsume{
		Id = 349,
		SizeDay = 649,
		SizeNight = 164,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 149
	},
	new EnergyConsume{
		Id = 350,
		SizeDay = 202,
		SizeNight = 225,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 150
	},
	new EnergyConsume{
		Id = 351,
		SizeDay = 277,
		SizeNight = 350,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 151
	},
	new EnergyConsume{
		Id = 352,
		SizeDay = 359,
		SizeNight = 160,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 152
	},
	new EnergyConsume{
		Id = 353,
		SizeDay = 706,
		SizeNight = 324,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 153
	},
	new EnergyConsume{
		Id = 354,
		SizeDay = 617,
		SizeNight = 341,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 154
	},
	new EnergyConsume{
		Id = 355,
		SizeDay = 740,
		SizeNight = 485,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 155
	},
	new EnergyConsume{
		Id = 356,
		SizeDay = 662,
		SizeNight = 210,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 156
	},
	new EnergyConsume{
		Id = 357,
		SizeDay = 561,
		SizeNight = 259,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 157
	},
	new EnergyConsume{
		Id = 358,
		SizeDay = 243,
		SizeNight = 294,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 158
	},
	new EnergyConsume{
		Id = 359,
		SizeDay = 759,
		SizeNight = 359,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 159
	},
	new EnergyConsume{
		Id = 360,
		SizeDay = 728,
		SizeNight = 242,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 160
	},
	new EnergyConsume{
		Id = 361,
		SizeDay = 376,
		SizeNight = 393,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 161
	},
	new EnergyConsume{
		Id = 362,
		SizeDay = 221,
		SizeNight = 437,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 162
	},
	new EnergyConsume{
		Id = 363,
		SizeDay = 650,
		SizeNight = 275,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 163
	},
	new EnergyConsume{
		Id = 364,
		SizeDay = 509,
		SizeNight = 213,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 164
	},
	new EnergyConsume{
		Id = 365,
		SizeDay = 446,
		SizeNight = 252,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 165
	},
	new EnergyConsume{
		Id = 366,
		SizeDay = 620,
		SizeNight = 421,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 166
	},
	new EnergyConsume{
		Id = 367,
		SizeDay = 516,
		SizeNight = 237,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 167
	},
	new EnergyConsume{
		Id = 368,
		SizeDay = 230,
		SizeNight = 280,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 168
	},
	new EnergyConsume{
		Id = 369,
		SizeDay = 728,
		SizeNight = 185,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 169
	},
	new EnergyConsume{
		Id = 370,
		SizeDay = 530,
		SizeNight = 150,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 170
	},
	new EnergyConsume{
		Id = 371,
		SizeDay = 405,
		SizeNight = 227,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 171
	},
	new EnergyConsume{
		Id = 372,
		SizeDay = 296,
		SizeNight = 492,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 172
	},
	new EnergyConsume{
		Id = 373,
		SizeDay = 558,
		SizeNight = 307,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 173
	},
	new EnergyConsume{
		Id = 374,
		SizeDay = 747,
		SizeNight = 423,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 174
	},
	new EnergyConsume{
		Id = 375,
		SizeDay = 716,
		SizeNight = 378,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 175
	},
	new EnergyConsume{
		Id = 376,
		SizeDay = 705,
		SizeNight = 163,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 176
	},
	new EnergyConsume{
		Id = 377,
		SizeDay = 366,
		SizeNight = 371,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 177
	},
	new EnergyConsume{
		Id = 378,
		SizeDay = 718,
		SizeNight = 264,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 178
	},
	new EnergyConsume{
		Id = 379,
		SizeDay = 669,
		SizeNight = 413,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 179
	},
	new EnergyConsume{
		Id = 380,
		SizeDay = 427,
		SizeNight = 331,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 180
	},
	new EnergyConsume{
		Id = 381,
		SizeDay = 730,
		SizeNight = 280,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 181
	},
	new EnergyConsume{
		Id = 382,
		SizeDay = 739,
		SizeNight = 288,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 182
	},
	new EnergyConsume{
		Id = 383,
		SizeDay = 485,
		SizeNight = 247,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 183
	},
	new EnergyConsume{
		Id = 384,
		SizeDay = 762,
		SizeNight = 310,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 184
	},
	new EnergyConsume{
		Id = 385,
		SizeDay = 462,
		SizeNight = 395,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 185
	},
	new EnergyConsume{
		Id = 386,
		SizeDay = 406,
		SizeNight = 443,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 186
	},
	new EnergyConsume{
		Id = 387,
		SizeDay = 493,
		SizeNight = 382,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 187
	},
	new EnergyConsume{
		Id = 388,
		SizeDay = 656,
		SizeNight = 368,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 188
	},
	new EnergyConsume{
		Id = 389,
		SizeDay = 235,
		SizeNight = 388,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 189
	},
	new EnergyConsume{
		Id = 390,
		SizeDay = 295,
		SizeNight = 455,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 190
	},
	new EnergyConsume{
		Id = 391,
		SizeDay = 725,
		SizeNight = 259,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 191
	},
	new EnergyConsume{
		Id = 392,
		SizeDay = 746,
		SizeNight = 264,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 192
	},
	new EnergyConsume{
		Id = 393,
		SizeDay = 389,
		SizeNight = 491,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 193
	},
	new EnergyConsume{
		Id = 394,
		SizeDay = 313,
		SizeNight = 477,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 194
	},
	new EnergyConsume{
		Id = 395,
		SizeDay = 332,
		SizeNight = 339,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 195
	},
	new EnergyConsume{
		Id = 396,
		SizeDay = 409,
		SizeNight = 297,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 196
	},
	new EnergyConsume{
		Id = 397,
		SizeDay = 608,
		SizeNight = 463,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 197
	},
	new EnergyConsume{
		Id = 398,
		SizeDay = 534,
		SizeNight = 194,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 198
	},
	new EnergyConsume{
		Id = 399,
		SizeDay = 633,
		SizeNight = 252,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 199
	},
	new EnergyConsume{
		Id = 400,
		SizeDay = 611,
		SizeNight = 325,
		Date = Convert.ToDateTime("11.05.22"),
		UnitId = 200
	}
    };

        public void Seeding(EntityTypeBuilder<EnergyConsume> builder) => builder.HasData(energyConsume);
    }
}
