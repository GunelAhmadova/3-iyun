using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    class Employee
    {
        private string _name;
        private string _surname;
        private int _salary; //Employee Name və Surname dəyərləri 
                             //yalnız hərflərdən ibarət olmalıdır və
                             //Böyük hərflə başlamalıdır


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool check = false;
                if (Char.IsUpper(value[0]))
                {

                    for (int i = 0; i < value.Length; i++)
                    {  
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                           
                        }
                        else
                        {
                            check = false;
                            break;

                        }
                        
                        
                    }

                    if (check==true)
                    {
                        _name = value;
                    }
                } 




            }
        }
        public string SurName
        {
            get
            {
                return _surname;
            } 
            set
            {
                bool check = false;
                if (Char.IsUpper(value[0]))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check == true)
                    {
                        _surname = value;
                    }
                }
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            } 
            set
            {
                if (250 < value)
                {
                    _salary = value;
                }
            }
        }
    }
}
