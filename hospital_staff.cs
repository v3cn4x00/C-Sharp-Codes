using System;
namespace Assignment_2
{
    class HospitalStaff
    {
        public string StaffID;
        public string Name;
        public string Department;

        public HospitalStaff(string staffID, string name, string department)
        {
            StaffID = staffID;
            Name = name;
            Department = department;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Staff ID: {StaffID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Doctor : HospitalStaff
    {
        public string Specialization;

        public Doctor(string staffID, string name, string department, string specialization)
            : base(staffID, name, department)
        {
            Specialization = specialization;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }

    class Nurse : HospitalStaff
    {
        public string Shift;

        public Nurse(string staffID, string name, string department, string shift)
            : base(staffID, name, department)
        {
            Shift = shift;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Shift: {Shift}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HospitalStaff[] staff = new HospitalStaff[4];
            staff[0] = new Doctor("D001", "Dr. Smith", "Cardiology", "Cardiologist");
            staff[1] = new Doctor("D002", "Dr. Johnson", "Neurology", "Neurologist");
            staff[2] = new Nurse("N001", "Nurse Brown", "Pediatrics", "Day");
            staff[3] = new Nurse("N002", "Nurse Davis", "Emergency", "Night");

            Console.WriteLine("Hospital Staff Details");

            for (int i = 0; i < staff.Length; i++)
            {
                Console.WriteLine("------------------------------\n");
                Console.WriteLine($"Staff Member {i + 1}:");
                staff[i].DisplayDetails();
            }
        }
    }


}
