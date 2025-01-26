using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SigninWithCRUD
{
    internal class ssCrud
    {
        public string newOption;
        public string[] CNIC = new string[5];
        public string[] name = new string[5];
        public string[] password = new string[5];
        public string[] position = new string[5];
        public string[] fullname = new string[5];
        public string[] petName = new string[5];
        public string[] specie = new string[5];
        public string[] gender= new string[5];
        public string[] age = new string[5];
        public string[] history= new string[5];
        public string[] food= new string[5];
        public string[] updatedDisease=new string[5];
        public string[] updatedMedicine= new string[5];
        public int count = 0;
        const string path = "C:\\Users\\MR NoN\\Downloads\\data\\file.txt";
        public string signUp()
        {
            if (count >= CNIC.Length)
            {
                return "No more Space ....";
            }
            Console.Write("\t\t\tEnter your name to sign up:");
            name[count] = Console.ReadLine();
            Console.Write("\t\t\tEnter Password :");
            password[count] = Console.ReadLine();
            Console.Write("\t\t\tEnter position :");
            position[count] = Console.ReadLine();
            while (true)
            {

                Console.Write("\t\t\tEnter your CNIC :");
                string inputCNIC = Console.ReadLine();
                if (inputCNIC.Length == 13)
                {
                    if (Array.Exists(CNIC, c => c == inputCNIC))
                    {
                        Console.WriteLine("This CNIC is already registered.");
                        continue;
                    }
                    CNIC[count] = inputCNIC;
                    count++;
                    return "Sign up Successful .......Please enter for options";

                }
                else
                {
                    Console.WriteLine("Invalid");
                    return "Invalid";
                }



            }
        }
        public string signIn()
        {
            Console.WriteLine("\t\t\tEnter your CNIC");
            string inputCNIC = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (CNIC[i] == inputCNIC)
                {
                    return "SIGN in SUCcessful";
                }
            }
            return "INvalid";

        }
        public void readData()
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string result;
                while ((result = file.ReadLine()) != null)
                {
                    if (count >= CNIC.Length)
                    {
                        Console.WriteLine("no data");
                        break;
                    }
                    CNIC[count] = result;
                    count++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("no file found.");
            }
        }

        public void writeData()
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < count; i++)
            {
                file.WriteLine(CNIC[i]);
            }
            file.Flush();
            file.Close();

        }
        public void registerPetMenu(ref int count, string[] fullname, string[] petName, string[] specie, string[] gender, string[] age, string[] history, string[] food, string[] updatedDisease, string[] updatedMedicine)
        {



            
            Console.WriteLine("\t\t\tEnter Owner's Full name :");
            fullname[count]= Console.ReadLine();


            Console.WriteLine("t\t\tEnter Pet's name :");
            petName[count] = Console.ReadLine();

            
            Console.WriteLine("\t\t\tEnter Pet's Specie :");
            specie[count] = Console.ReadLine();


            Console.WriteLine("\t\t\tEnter Pet's Gender :");
            gender[count] = Console.ReadLine();


            Console.WriteLine("\t\t\tEnter Estimated age :");
            age[count] = Console.ReadLine();


            Console.WriteLine("\t\t\tEnter Vaccination history :");
            history[count] = Console.ReadLine();
           
           Console.WriteLine("\t\t\tEnter type of food and feeding schedule :");
            
           food[count] = Console.ReadLine();


            Console.WriteLine("\t\t\tEnter the current disease :");
            updatedDisease[count] = Console.ReadLine();
            

            
           Console.WriteLine("\t\t\tEnter the current medicine :");
           
            updatedMedicine[count] = Console.ReadLine();
            count++;
        }
        public void updatePetMenu(ref int count, string[] name, string[] petName, string[] specie, string[] gender, string[] age, string[] history, string[] food, string[] updatedDisease, string[] updatedMedicine)
        {
            string updatedName;
            string updatedPetName;
            string updatedSpecie;
            string updatedHistory;
            string updatedFood;
            string updatedGender;
            string updatedDisease1;
            string updatedMedicine1;
            string updatedAge;
            

            
            Console.WriteLine(" please write updated name :");

            updatedName = Console.ReadLine();
            Console.WriteLine(" please write pet's updated name :");
            updatedPetName=Console.ReadLine();
            Console.WriteLine(" please write updated specie :");
            
            updatedSpecie=Console.ReadLine();


            Console.WriteLine(" please write updated age :");
           
            updatedAge=Console.ReadLine();

            Console.WriteLine(" Enter Gender :");
            
           updatedGender=Console.ReadLine();

           
            Console.WriteLine(" Enter current disease :");
           
            updatedDisease1=Console.ReadLine();

           
            Console.WriteLine(" Updated food schedule :  ");
            
            updatedFood=Console.ReadLine();

            
            Console.WriteLine(" Enter current Medicine :");
           
            updatedMedicine1=Console.ReadLine();


            Console.WriteLine(" Enter current Vaccination History :");
           
            updatedHistory=Console.ReadLine();

            name[count] = updatedName;
            petName[count] = updatedPetName;
            specie[count] = updatedSpecie;
            age[count] = updatedAge;
            gender[count] = updatedGender;
            history[count] = updatedHistory;
            updatedDisease[count] = updatedDisease1;
            food[count] = updatedFood;
            updatedMedicine[count] = updatedMedicine1;

            
        }
        /*--------------------------------------------SEARCH NAME TO UPDATE DATA---------------------------------------*/
        public int searchName(ref int count, string[] name, string[] updatedDisease)
        {

            string searchName;
            string currentDisease;
            bool found = false;


            Console.WriteLine("\t\t\t Enter the name of owner for furthur process : ");
            
            searchName=Console.ReadLine();

            Console.WriteLine("\t\t\t Enter Disease of your Pet : ");
            
            currentDisease=Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (name[i] == searchName && updatedDisease[i] == currentDisease)
                {
                    found = true;
                    return i;
                }
            }
            return -1;
        }

        public void checkReport(int index, string[] name, string[] petName, string[] specie, string[] gender, string[] age, string[] history, string[] food, string[] updatedDisease, string[] updatedMedicine)
        {


            if (index >= 0 && index < 15)
            {

                Console.WriteLine(" \tThe report of Patient is given below :");

                Console.WriteLine("Name of Customer is   :  {name[index]}");
                Console.WriteLine("Name of Pet is   :{petName[index]}");
                Console.WriteLine("Name of Specie is   :{specie[index] }");
                Console.WriteLine("Gender of pet is   : {gender[index]}");
                Console.WriteLine("Age of Pet is   :{age[index]}");
                Console.WriteLine("Vaccination history of pet    :{ history[index]}");
                Console.WriteLine("Type of food and feeding schedule    :{food[index]}");
                Console.WriteLine("Current Disease    :{updatedDisease[index]}");
                Console.WriteLine("Current Vaccination   :updatedMedicine[index]}");
            }

         
        }
        /*------------------------------------------------DELETE PET RECORD----------------------------------------------*/

        public int searchPetName(ref int count, string[] petName, string[] updatedDisease)
        {

            string petNameToDelete;
            string updatedDiseaseFind;
            bool found = false;


            Console.WriteLine("\t\t\t Enter the pet name to delete: ");
            
             petNameToDelete=Console.ReadLine();
            Console.WriteLine("\t\t\t Enter the disease of pet :");

            updatedDiseaseFind=Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (petName[i] == petNameToDelete && updatedDisease[i] == updatedDiseaseFind)
                {
                    found = true;
                    return i;
                }
            }
            return -1;
        }

        /*---------------------------------------------DELETE DATA------------------------------------------------------*/

        public void deletePetData(ref int count, int index, string[] name, string[] petName, string[] specie, string[] gender, string[] age, string[] history, string[] food, string[] updatedDisease, string[] updatedMedicine)
        {
            for (int i = index; i < count - 1; i++)
            {
                name[i] = name[i + 1];
                petName[i] = petName[i + 1];
                specie[i] = specie[i + 1];
                gender[i] = gender[i + 1];
                age[i] = age[i + 1];
                history[i] = history[i + 1];
                food[i] = food[i + 1];
                updatedDisease[i] = updatedDisease[i + 1];
                updatedMedicine[i] = updatedMedicine[i + 1];
            }
            count--;
        }


    }
}
