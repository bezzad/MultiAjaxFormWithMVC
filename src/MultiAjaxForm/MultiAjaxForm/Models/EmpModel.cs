using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultiAjaxForm.Models
{
    public class EmpModel
    {
        public static List<EmpModel> Employes;
        static EmpModel()
        {
            Employes = new List<EmpModel>
            {
                new EmpModel()
                {
                    Name = "Adriana C. Ocampo Uria",
                    Address = "ARMED FORCES PACIFIC, UNIT 2050 BOX 490",
                    City = "APO"
                },
                new EmpModel()
                {
                    Name = "Albert Einstein",
                    Address = "ARMED FORCES AMERICAS, PSC 802 BOX 2625",
                    City = "APO"
                },
                new EmpModel()
                {
                    Name = "Anna K. Behrensmeyer",
                    Address = "NORTH DAKOTA, 2020 GOVERNMENT AVE",
                    City = "MINOT AFB"
                },
                new EmpModel()
                {
                    Name = "Blaise Pascal",
                    Address = "	1010 EASY ST",
                    City = "OTTAWA"
                },
                new EmpModel()
                {
                    Name = "Caroline Herschel",
                    Address = "1010 CENTER ST",
                    City = "North Sydney"
                },
                new EmpModel()
                {
                    Name = "Cecilia Payne-Gaposchkin",
                    Address = "Box 74 RR1",
                    City = "North Sydney"
                },
                new EmpModel()
                {
                    Name = "Chien-Shiung Wu",
                    Address = "HARTMANNSTRASSE 7",
                    City = "BONN"
                },
                new EmpModel()
                {
                    Name = "Dorothy Hodgkin",
                    Address = "Tabriz, Golpark Apartment",
                    City = "Tabriz"
                },
                new EmpModel()
                {
                    Name = "Edmond Halley",
                    Address = "Tabriz, Golpark Apartment",
                    City = "Tabriz"
                },
                new EmpModel()
                {
                    Name = "Edwin Powell Hubble",
                    Address = "Tabriz, Golpark Apartment",
                    City = "Tabriz"
                },
                new EmpModel()
                {
                    Name = "Elizabeth Blackburn",
                    Address = "3F #12 LN 410 SEC, 2 PA-TEH RD",
                    City = "TAIPEI"
                },
                new EmpModel()
                {
                    Name = "Enrico Fermi",
                    Address = "UW ROME CENTER, PIAZZA DEL BISCIONE 95",
                    City = "ROME"
                },
                new EmpModel()
                {
                    Name = "Ingrid Daubechies",
                    Address = "1055-2 JAESONG-DONG, HAEWOONDAE-KU",
                    City = "PUSAN"
                },
                new EmpModel()
                {
                    Name = "Behzad Khosravifar",
                    Address = "Tavanir, Golpark Apartment",
                    City = "Tabriz"
                },
                new EmpModel()
                {
                    Name = "Jacqueline K. Barton",
                    Address = "490 E Main Street",
                    City = "Norwich"
                },
                new EmpModel()
                {
                    Name = "Lord Kelvin",
                    Address = "61 Greenhaven Road",
                    City = "Pawcatuck"
                }
            };
        }

        public Guid AutoId { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }

        public bool Active { get; set; } = true;
    }
}
