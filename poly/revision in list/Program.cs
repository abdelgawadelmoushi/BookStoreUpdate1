using System.Dynamic;
using System.Linq;

namespace revision_in_list
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Positive

            //var numbers = new[] { 1, -1, -3, -5, 6, 7 };


            //var positiveNumber = GetPossitiveOnly(numbers, out int countofnonPositiveNumbers);



            //foreach (var positive in positiveNumber)

            //{
            //    Console.WriteLine(positive);
            //}
            //Console.WriteLine("Count of non Positive numbers");
            //Console.WriteLine(countofnonPositiveNumbers);


            //List<int> GetPossitiveOnly(int[] numbers, out int countofnonPositiveNumbers)
            //{

            //    countofnonPositiveNumbers = 0;

            //    var result = new List<int>();

            //    foreach (var number in numbers)
            //    {
            //        if (number > 0)

            //        { result.Add(number); }
            //        else
            //        {
            //            countofnonPositiveNumbers++;
            //        }
            //    }

            //    return result;

            //}

            #endregion

            #region TODO LIST

            void ShowMenu()
            {
                Console.WriteLine("[S]ee All TODOS \n" +
                "[A]dd TODO \n" +
                "[R]emove a TODO \n" +
                "[E]xit");
            }
                List<string> TODO = new List<string> { " play", "standup " };

                void AddTodo()
                {

                    bool isvalidDescription = false;

                    while (!isvalidDescription)
                    {
                        Console.WriteLine("please add TODO");
                        string addTODO = Console.ReadLine();

                        if (addTODO == "")
                        {
                        canNotbeImpty();
                    }
                        else if (TODO.Contains(addTODO))
                        {
                            Console.WriteLine("the TODO must be unique");
                        }
                        else
                        {
                            isvalidDescription = true;
                            TODO.Add(addTODO);
                        }
                    }


                }

            void showToDos ()
            {

                int i = 0;
                for (i = 0; i < TODO.Count; i++)
                {
                    Console.WriteLine(TODO[i]);
                }
            }
                bool vaildChoice = false;
                while (!vaildChoice)
                {
                ShowMenu();
                string userInput = Console.ReadLine();

                    if (userInput == "")
                {
                    canNotbeImpty();
                }

                void removeToDO()
                {
                 

                    Console.WriteLine("Enter the number of the TODO to remove:");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine(" Your choice cannot be empty");
                    }
                    else if (int.TryParse(input, out int index) && index >= 1 && index <= TODO.Count)
                    {
                        var todoToBeRemoved = TODO[index - 1];
                        TODO.RemoveAt(index - 1);
                        Console.WriteLine($"TODO Removed: {todoToBeRemoved}");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid number");
                    }
                }


                switch (userInput)
                        {
                            case "S":
                            case "s":
                            showToDos();
                            ShowMenu();
                            break;

                            case "A":
                            case "a":
                                AddTodo();
                                Console.WriteLine("TODO has been Added");
                        showToDos();
                        ShowMenu();
                                break;
                            case "R":
                            case "r":
                        removeToDO();
                                break;
                    case "E":
                    case "e":
                        vaildChoice = true;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                                break;
                        }
                    }
           
            Console.ReadLine();

                    #endregion
                }

        private static void canNotbeImpty()
        {
            Console.WriteLine("user Input can not be null");
        }
    }
        }

    
