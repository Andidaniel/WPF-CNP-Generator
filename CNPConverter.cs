using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Converters_example
{ 
    public class CNPConverter:IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            StringBuilder CNP = new StringBuilder("-------------");

            if (values != null)
            {
                /*
                 * This Calculates the gender digit of the person's ID Number based on the year they were
                 * born (Only accepts people born since 1900)
                 */
                if (values[0] != "")
                {
                    switch (values[0])
                    {
                        case "Female":
                            if (values[1].ToString() != "")
                            {
                                if (values[1].ToString()[7] == '9')
                                {
                                    CNP[0] = '2';
                                }
                                else
                                {
                                    CNP[0] = '6';
                                }
                            }
                            break;
                        case "Male":
                            if (values[1].ToString() != "")
                            {
                                if (values[1].ToString()[7] == '9')
                                {
                                    CNP[0] = '1';
                                }
                                else
                                {
                                    CNP[0] = '5';
                                }
                            }

                            break;
                        default:
                            break;
                    }
                }

                /*
                 * This calculates the six digits representing a person's birthdate in their ID number
                 */
                if (values[1] != "")
                {
                    CNP[1] = values[1].ToString()[8];
                    CNP[2] = values[1].ToString()[9];
                    CNP[3] = values[1].ToString()[3];
                    CNP[4] = values[1].ToString()[4];
                    CNP[5] = values[1].ToString()[0];
                    CNP[6] = values[1].ToString()[1];
                }
                /*
                 * This calculates the two digits representing the birthplace of a person if their ID number
                 * !!! WARNING !!! EXPAND SWITCH AT YOUR OWN RISK !!!
                 */
                switch (values[2].ToString())
                {
                    case "Alba":
                        CNP[7] = '0';
                        CNP[8] = '1';
                        break; 
                    case "Arad":
                        CNP[7] = '0';
                        CNP[8] = '2';
                        break; 
                    case "Arges":
                        CNP[7] = '0';
                        CNP[8] = '3';
                        break; 
                    case "Bacau":
                        CNP[7] = '0';
                        CNP[8] = '4';
                        break; 
                    case "Bihor":
                        CNP[7] = '0';
                        CNP[8] = '5';
                        break; 
                    case "Bistrita-Nasaud":
                        CNP[7] = '0';
                        CNP[8] = '6';
                        break; 
                    case "Botosani":
                        CNP[7] = '0';
                        CNP[8] = '7';
                        break; 
                    case "Brasov":
                        CNP[7] = '0';
                        CNP[8] = '8';
                        break; 
                    case "Braila":
                        CNP[7] = '0';
                        CNP[8] = '9';
                        break; 
                    case "Buzau":
                        CNP[7] = '1';
                        CNP[8] = '0';
                        break; 
                    case "Caras-Severin":
                        CNP[7] = '1';
                        CNP[8] = '1';
                        break; 
                    case "Cluj":
                        CNP[7] = '1';
                        CNP[8] = '2';
                        break; 
                    case "Constanta":
                        CNP[7] = '1';
                        CNP[8] = '3';
                        break; 
                    case "Covasna":
                        CNP[7] = '1';
                        CNP[8] = '4';
                        break; 
                    case "Dambovita":
                        CNP[7] = '1';
                        CNP[8] = '5';
                        break; 
                    case "Dolj":
                        CNP[7] = '1';
                        CNP[8] = '6';
                        break; 
                    case "Galati":
                        CNP[7] = '1';
                        CNP[8] = '7';
                        break; 
                    case "Gorj":
                        CNP[7] = '1';
                        CNP[8] = '8';
                        break; 
                    case "Harghita":
                        CNP[7] = '1';
                        CNP[8] = '9';
                        break; 
                    case "Hunedoara":
                        CNP[7] = '2';
                        CNP[8] = '0';
                        break; 
                    case "Ialomita":
                        CNP[7] = '2';
                        CNP[8] = '1';
                        break; 
                    case "Iasi":
                        CNP[7] = '2';
                        CNP[8] = '2';
                        break; 
                    case "Ilfov":
                        CNP[7] = '2';
                        CNP[8] = '3';
                        break;
                    case "Maramures":
                        CNP[7] = '2';
                        CNP[8] = '4';
                        break; 
                    case "Mehedinti":
                        CNP[7] = '2';
                        CNP[8] = '5';
                        break; 
                    case "Mures":
                        CNP[7] = '2';
                        CNP[8] = '6';
                        break; 
                    case "Neamt":
                        CNP[7] = '2';
                        CNP[8] = '7';
                        break; 
                    case "Olt":
                        CNP[7] = '2';
                        CNP[8] = '8';
                        break; 
                    case "Prahova":
                        CNP[7] = '2';
                        CNP[8] = '9';
                        break; 
                    case "Satu Mare":
                        CNP[7] = '3';
                        CNP[8] = '0';
                        break; 
                    case "Salaj":
                        CNP[7] = '3';
                        CNP[8] = '1';
                        break; 
                    case "Sibiu":
                        CNP[7] = '3';
                        CNP[8] = '2';
                        break; 
                    case "Suceava":
                        CNP[7] = '3';
                        CNP[8] = '3';
                        break; 
                    case "Teleorman":
                        CNP[7] = '3';
                        CNP[8] = '4';
                        break; 
                    case "Timis":
                        CNP[7] = '3';
                        CNP[8] = '5';
                        break; 
                    case "Tulcea":
                        CNP[7] = '3';
                        CNP[8] = '6';
                        break; 
                    case "Vaslui":
                        CNP[7] = '3';
                        CNP[8] = '7';
                        break; 
                    case "Valcea":
                        CNP[7] = '3';
                        CNP[8] = '8';
                        break; 
                    case "Vrancea":
                        CNP[7] = '3';
                        CNP[8] = '9';
                        break; 
                    case "Bucuresti":
                        CNP[7] = '4';
                        CNP[8] = '0';
                        break; 
                    case "Bucuresti - Sector 1":
                        CNP[7] = '4';
                        CNP[8] = '1';
                        break; 
                    case "Bucuresti - Sector 2":
                        CNP[7] = '4';
                        CNP[8] = '2';
                        break; 
                    case "Bucuresti - Sector 3":
                        CNP[7] = '4';
                        CNP[8] = '3';
                        break;
                    case "Bucuresti - Sector 4":
                        CNP[7] = '4';
                        CNP[8] = '4';
                        break; 
                    case "Bucuresti - Sector 5":
                        CNP[7] = '4';
                        CNP[8] = '5';
                        break; 
                    case "Bucuresti - Sector 6":
                        CNP[7] = '4';
                        CNP[8] = '6';
                        break; 
                    case "Calarasi":
                        CNP[7] = '5';
                        CNP[8] = '1';
                        break; 
                    case "Giurgiu":
                        CNP[7] = '5';
                        CNP[8] = '2';
                        break;
                }


                if (values[0] != "" && values[1] != "" && values[2] != "")
                {
                    Random r = new Random();
                    const string constValue = "279146358279";
                    int rand_no = r.Next(1000);
                    if (rand_no < 100)
                    {
                        if (rand_no < 10)
                        {
                            CNP[9] = '0';
                            CNP[10] = '0';
                            CNP[11] = rand_no.ToString()[0];
                        }
                        else
                        {
                            CNP[9] = '0';
                            CNP[10] = rand_no.ToString()[0];
                            CNP[11] = rand_no.ToString()[1];
                        }
                    }
                    else
                    {
                        CNP[9] = rand_no.ToString()[0];
                        CNP[10] = rand_no.ToString()[1];
                        CNP[11] = rand_no.ToString()[2];

                    }

                    int number = 0;
                    for(int i=0;i<constValue.Length;i++)
                    {
                        number += (constValue[i] - '0') * (CNP[i] - '0');
                    }

                    if (number % 11 < 10)
                    {
                        CNP[12] = (char)('0' + (number % 11));
                    }
                    else
                    {
                        CNP[12] = '1';
                    }

                }



            }
            if(CNP.ToString().Contains('-'))
            {
                return "Please fill in all the fields";
            }
            else
            {
                return "Generated CNP: "+CNP.ToString();
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
