using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ExceptionList().ForEach(exception =>
            {
                try
                {
                    throw exception;
                }

                catch(CustomException)
                {
                    Console.WriteLine("Пользовательский тип исключения");
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }

                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Ключ не найден");
                }

                catch(FileNotFoundException)
                {
                    Console.WriteLine("Файл не найден");
                }

                catch(Exception)
                {
                    Console.WriteLine("Стандартный тип исключения");
                }

                finally
                {

                }
                
            });

            Console.Read();

        }

        private static List<Exception> ExceptionList() {
            List<Exception> exceptionList = new List<Exception>();

            exceptionList.Add(new Exception());
            exceptionList.Add(new CustomException());
            exceptionList.Add(new DivideByZeroException());
            exceptionList.Add(new KeyNotFoundException());
            exceptionList.Add(new FileNotFoundException());

            return exceptionList;
        }

    }
    class CustomException : ArgumentNullException
    {

    }
}
