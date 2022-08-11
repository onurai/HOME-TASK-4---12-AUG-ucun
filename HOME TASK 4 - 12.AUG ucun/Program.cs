using System;

namespace HOME_TASK_4___12.AUG_ucun
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(1999, 05, 27);

            //Console.WriteLine(dateTime.DayOfWeek);
            //Console.WriteLine((int)dateTime.DayOfWeek);



            //DateTime myBirthdate = new DateTime(1999, 05, 27);
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            //Console.WriteLine((int)myAge.TotalDays);




            //Console.WriteLine("Enter Day :");
            //string weekday = Console.ReadLine();
            //int weekdayNum = int.Parse(weekday);

            //switch (weekdayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Enter valid number");
            //        break;
            //}



            //int first, second, third;  Bunu yaza da bilerik yazmaya da...Burda bunu yazanda asagida int sozunu yazmiriq.


            //Console.WriteLine("Enter the first number : ");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number : ");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number : ");
            //int third = int.Parse(Console.ReadLine());


            //if (first > second)
            //{

            //    if (first > third)
            //    {
            //        Console.WriteLine("largest number : " + first);
            //    }
            //    else
            //    {
            //        Console.WriteLine("largest number : " + third);
            //    }
            //}
            //else
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine("largest number : " + second);
            //    }
            //    else
            //    {
            //        Console.WriteLine("largest number : " + third);
            //    }
            //}


            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);

                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("EXIT");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;

            int main() {

  char op;
  double first, second;
  printf("Enter an operator (+, -, *, /): ");
  scanf("%c", &op);
  printf("Enter two operands: ");
  scanf("%lf %lf", &first, &second);

  switch (op) {
    case '+':
      printf("%.1lf + %.1lf = %.1lf", first, second, first + second);
      break;
    case '-':
      printf("%.1lf - %.1lf = %.1lf", first, second, first - second);
      break;
    case '*':
      printf("%.1lf * %.1lf = %.1lf", first, second, first * second);
      break;
    case '/':
      printf("%.1lf / %.1lf = %.1lf", first, second, first / second);
      break;
    // operator doesn't match any case constant
    default:
      printf("Error! operator is not correct");
  }

  return 0;
}
        }
    }
}
