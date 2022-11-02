using System;
using System.Collections.Generic;

namespace TestQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor()
            {
                Name = "Anas Qlok",
                Age = 30,
                Role = "Doctor",
                Salary = 35000.00m,
                WorkTime = 10
            };
            Doctor d2 = new Doctor()
            {
                Name = "Tobias Qlok",
                Age = 33,
                Role = "Doctor",
                Salary = 40000.00m,
                WorkTime = 12
            };
            Doctor d3 = new Doctor()
            {
                Name = "Reidar Qlok",
                Age = 40,
                Role = "Doctor",
                Salary = 32500.00m,
                WorkTime = 8
            };

            Nurse n1 = new Nurse()
            {
                Name = "Nurs",
                Age = 50,
                Role = "Nurse",
                Salary = 22500.00m,
                WorkTime = 8,
                IsNurse = true
            };
            Nurse n2 = new Nurse()
            {
                Name = "Srun",
                Age = 55,
                Role = "Nurse",
                Salary = 19200.00m,
                WorkTime = 6,
                IsNurse = true
            };

            Patient p1 = new Patient()
            {
                Name = "Pati Ent",
                Age = 20,
                Role = "Patient",
                Sickness = "Flu",
                TimeOfReg = new DateTime(2022, 06, 22, 14, 30, 20),
                TimeOfDepart = new DateTime(2022, 08, 12, 04, 10, 27)
            };
            Patient p2 = new Patient()
            {
                Name = "Ent Pati",
                Age = 23,
                Role = "Patient",
                Sickness = "Covid",
                TimeOfReg = new DateTime(2020, 04, 22, 19, 58, 53),
                TimeOfDepart = new DateTime(2020, 10, 22, 14, 10, 02)
            };
            Patient p3 = new Patient()
            {
                Name = "Ten Itap",
                Age = 33,
                Role = "Patient",
                Sickness = "Covid",
                TimeOfReg = new DateTime(2021, 03, 20, 22, 53, 23),
                TimeOfDepart = new DateTime(2021, 07, 17, 01, 51, 40)
            };

            List<Doctor> dList = new List<Doctor>() { d1, d2, d3};
            List<Nurse> nList = new List<Nurse>() { n1, n2 };
            List<Patient> pList = new List<Patient>() { p1, p2, p3 };

            d1.WriteReceipt(p2);

            foreach (Doctor d in dList)
            {
                Console.WriteLine($"-DOCTOR- \n Name: {d.Name} \n Age: {d.Age} \n Job: {d.Role} \n Salary: {d.Salary} \n WorkTime: {d.WorkTime}");
                Console.WriteLine();
            }
            foreach (Nurse n in nList)
            {
                Console.WriteLine($"-NURSE- \n Name: {n.Name} \n Age: {n.Age} \n Job: {n.Role} \n Salary: {n.Salary} \n WorkTime: {n.WorkTime} \n IsNurse: {n.IsNurse}");
                Console.WriteLine();
            }
            foreach (Patient p in pList)
            {
                Console.WriteLine($"-PATIENT- \n Name: {p.Name} \n Age: {p.Age} \n Role: {p.Role} \n Sickness: {p.Sickness} \n Date of registration: {p.TimeOfReg} \n Date of departure: {p.TimeOfDepart} \n Has been given a receipt: {p.HasReceipt}");
                Console.WriteLine();
            }

            Queue<Patient> patientQueue = new Queue<Patient>();
            patientQueue.Enqueue(p1);
            patientQueue.Enqueue(p2);
            patientQueue.Enqueue(p3);

            for (int i = 0; i <= patientQueue.Count + 1; i++)
            {
                Console.WriteLine($"{pList[i].Name} has been given a covid vaccination!");
                patientQueue.Dequeue();
            }

            Console.WriteLine();

            if (patientQueue.Count == 0)
            {
                Console.WriteLine("All patients have been given a covid vaccination!");
            }

        }
    }
}
