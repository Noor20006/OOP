using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SigninWithCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {



            ssCrud s1 = new ssCrud();


            Console.WriteLine(" , __                                             ___  _                            _                      ");
            Console.WriteLine("/|/  |                                     |     / (_)| |                          | | o          o        ");
            Console.WriteLine(" |___/ __,           ,     __,   _  _    __|    |     | |  __,           ,     __  | |     _  _       __   ");
            Console.WriteLine(" |    /  |  |  |  |_/ |_  /  |  / |/ |  /  |    |     |/  /  |  |  |  |_/ |_  /    |/  |  / |/ |  |  /     ");
            Console.WriteLine(" |    |_/|_/ || ||   ||   |_/|_/  |  |_/|_/|_/   |___/|__/|_/|_/ || ||   ||   |___/|__/|_/  |  |_/|_/|___/ ");
            Console.WriteLine("                                                                                                           ");
            bool val;
            const int x = 15;
            string input;


            s1.readData();
            while (true)
            {

                string newOption = showMenu();
                Console.Write(newOption);
                if (newOption == "1")
                {
                    string result = s1.signIn();
                    Console.WriteLine(result);
                    if (result == "SIGN in SUCcessful")
                    {
                        string data = veterinarianMenu();

                        while (data != "5")
                        {
                            switch (data)
                            {
                                case "1":
                                    val = true;
                                    while (val && s1.count < x)
                                    {
                                        if (s1.count >= x)
                                        {
                                            Console.WriteLine("\t\t\tMaximum limit reached");
                                        }

                                        Console.WriteLine("\t\t\t\t\t(:Veterinarian Menu:");
                                        s1.registerPetMenu(ref s1.count, s1.name, s1.petName, s1.specie, s1.gender, s1.age, s1.history, s1.food, s1.updatedDisease, s1.updatedMedicine);

                                        Console.WriteLine(" Do you want to Register a new pet:   ");

                                        Console.WriteLine("\t if yes enter 1 \t if no enter 0   :");
                                        input = Console.ReadLine();

                                        if (input == "1")
                                        {
                                            val = true;
                                            //break;
                                        }

                                        else if (input == "0")
                                        {

                                            Console.WriteLine(" \t\t\t\tOkay The data is successfully Registered!");
                                            //s1.count++;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("wrong ");
                                        }
                                    }
                                    data = veterinarianMenu(); // Return to vet menu

                                    break;
                                case "2":

                                        val = true;
                                        while (val && s1.count < 15)
                                        {
                                            Console.WriteLine("\t\t\t\t\t(:Veterinarian Menu:)");
                                            int index = s1.searchName(ref s1.count, s1.name, s1.updatedDisease);
                                            if (index != -1)
                                            {

                                                s1.updatePetMenu(ref s1.count,s1. name,s1. petName, s1.specie, s1.gender, s1.age, s1.history, s1.food, s1.updatedDisease, s1.updatedMedicine);


                                            Console.WriteLine(" Do you want to Update a new pet:   ");

                                            Console.WriteLine("\t if yes enter 1 \t if no enter 0   :");
                                            input = Console.ReadLine();

                                            if (input == "1")
                                            {
                                                val = true;
                                                //break;
                                            }

                                            else if (input == "0")
                                                {

                                                Console.WriteLine(" \t\t\t\tOkay The data is successfully Updated!");
                                                //s1. count++;
                                                break;
                                                }
                                            else
                                            {
                                                Console.WriteLine("wrong ");
                                            }
                                            }
                                        }
                                    data = veterinarianMenu(); // Return to vet menu

                                    break;
                                case "3":
                                    val = true;
                                    while (val && s1.count < 15)
                                    {

                                       
                                       Console.WriteLine("\t\t\t\t\t(:Veterinarian Menu:)");
                                        
                                        int index = s1.searchName(ref s1.count, s1.name, s1.updatedDisease);
                                        if (index != -1)
                                        {
                                            s1.checkReport(index,s1. name, s1.petName, s1.specie, s1.gender, s1.age, s1.history, s1.food, s1.updatedDisease,s1. updatedMedicine);
                                        }
                                        else
                                        {

                                            Console.WriteLine("\t\t\t\tNo Report to display ");
                                        }

                                        Console.WriteLine(" Do you want to check one more report:   ");

                                        Console.WriteLine("\t if yes enter 1 \t if no enter 0   :");
                                         input = Console.ReadLine();

                                        if (input == "1")
                                        {
                                            val = true;
                                            
                                        }

                                        else if (input=="0")
                                        {
                                            
                                           Console.WriteLine(" \t\t\t\tOkay The data is successfully Displayed!" );
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("wrong option");
                                        }

                                    }
                                    data = veterinarianMenu(); // Return to vet menu

                                    break;
                                case "4":
                                    val = true;
                                    while (val)
                                    {
                                        Console.WriteLine("\t\t\t\t\t(:Veterinarian Menu:)");
                                       
                                        int index = s1.searchPetName(ref s1.count,s1. petName, s1.updatedDisease);
                                        if (index != -1)
                                        {
                                            s1.deletePetData(ref s1.count, index, s1.name, s1.petName, s1.specie, s1.gender, s1.age,s1. history, s1.food, s1.updatedDisease, s1.updatedMedicine);
                                        }
                                        else
                                        {

                                            Console.WriteLine("\t\t\t\tNo Report to delete ");
                                        }

                                        Console.WriteLine(" Do you want to del one more report:   ");

                                        Console.WriteLine("\tif yes enter 1\t if no enter 0 :");
                                        input = Console.ReadLine();

                                        if (input == "1")
                                        {
                                            val = true;
                                            
                                        }

                                        else if (input == "0")
                                        {

                                            
                                            Console.WriteLine(" \t\tOkay The data is successfully Deleted!");
                                            break;                                       
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong");
                                        }


                                    }
                                    data = veterinarianMenu(); // Return to vet menu

                                    break;
                            }
                            }




                        }

                    }
                


                else if (newOption == "2")
                {
                    string signUpOption = s1.signUp();
                    Console.Write(signUpOption);
                    s1.writeData();

                }
                else if (newOption == "3")
                {
                    Console.WriteLine("YOu have Exit the Program ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
                Console.ReadKey();
            }
        }
            

            static string showMenu()
            {
                string option;
                Console.WriteLine("\t\t\t1:Sign in :");
                Console.WriteLine("\t\t\t2:Sign up :");
                Console.WriteLine("\t\t\t3:Exit :");
                Console.Write("\tEnter your option   :");
                option = Console.ReadLine();
                return option;

            }
         static string veterinarianMenu()
        {
            
            
            Console.WriteLine("\t\t\t\t\t(:Veterinarian LOGIN:") ;


            Console.WriteLine("\t\tChoose what you want to do....") ;

            Console.WriteLine("\t\t\t1:Register new Pet ") ;
            Console.WriteLine("\t\t\t2:Update Treatment Plan");
            Console.WriteLine("\t\t\t3:Generate Health Report");
            Console.WriteLine("\t\t\t4:Delete Report") ;
            Console.WriteLine("\t\t\t5:Exit");
            Console.WriteLine("\t\tEnter Your Option (1 to 4):");
            string option;
            option = Console.ReadLine();
            return option;


        }
    }
    }
    

