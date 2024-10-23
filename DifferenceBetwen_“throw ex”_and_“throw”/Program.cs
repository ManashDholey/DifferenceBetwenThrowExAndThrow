using Customer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace DifferenceBetwen__throw_ex__and__throw_
{
    class Program
    {
        public const int cmToMeters = 8;//Compile time Constant.
        public  readonly double _PI ;//Run time constant.
        public  Program()
        {
            _PI = 3.14;
        }
        //static AutoResetEvent objeAuto = new AutoResetEvent(false);
        static ManualResetEvent objeAuto = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            try
            {
                IFirst obj2 = new TestFirst();
                obj2.Display(); // Calls IFirst.Display()

                Test obj1 = new Test();
                obj1.Display(); // Which Display() is called? 

                MyClass obj = new MyClass();

                // Call the general Display method
                obj.Display();

                // Call the interface-specific methods
                ((IFirst)obj).Display();
                ((ISecond)obj).Display();

                string str = "Manash Kumar Dholey  8296152878";
                //Using Anonymous Types
                var myInfo = Cust(ParseData(str), new
                {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "",
                    PhoneNumber = 0.0
                });
                Console.WriteLine("First Name:" + myInfo.FirstName);
                Console.WriteLine("Middele Name:" + myInfo.MiddleName);
                Console.WriteLine("Last Name:" + myInfo.LastName);
                Console.WriteLine("Phone number:" + myInfo.PhoneNumber);
                //Using Tuples
                var myInfoTuple = ParseDataUsingTuple(str);
                Console.WriteLine("First Name:" + myInfoTuple.Item1);
                Console.WriteLine("Middele Name:" + myInfoTuple.Item2);
                Console.WriteLine("Last Name:" + myInfoTuple.Item3);
                Console.WriteLine("Phone number:" + myInfoTuple.Item4);





                Sort.SortList();
                int i = 100;
                var y=((byte)i);
                var birthDate = new DateTime(1983, 10, 21);
                var thisYear = DateTime.Now; 
                    //new DateTime(DateTime.Today.Year, birthDate.Month, birthDate.Day);

                var dayOfWeek = thisYear.DayOfWeek;
                var time= thisYear.ToString("tt", CultureInfo.InvariantCulture);
                Guid obj4 = Guid.NewGuid();
                Program program = new Program();
                Singleton fromTeachaer = Singleton.GetInstance;
                fromTeachaer.PrintDetails("From Teacher");
                Singleton fromStudent = Singleton.GetInstance;
                fromStudent.PrintDetails("From Student");
                Console.ReadLine();
                Maths maths = new Maths();
                Thread th = new Thread(maths.Divide);
                th.Start();//Child thread
                maths.Divide();//main thread


                Thread thread = new Thread(Function1);
                Thread thread1 = new Thread(Function2);
                thread.Start();
                thread1.Start();
                new Thread(SomeMethod).Start();
                Console.ReadLine();
                objeAuto.Set();
                Console.ReadLine();
                objeAuto.Set();
                Console.ReadLine();
                objeAuto.Set();
               
                string strFirstName = "";
                string strMiddleName = "";
                string strSurname = "";
                double  phoneNumber = 0;
                ParseData(str, out strFirstName, out strMiddleName, out strSurname, out phoneNumber);
                Console.WriteLine("First Name:" + strFirstName);
                Console.WriteLine("Middele Name:" + strMiddleName);
                Console.WriteLine("Last Name:" + strSurname);
                Console.WriteLine("Phone number:" + phoneNumber);
                Console.ReadLine();
                var data = Class1.getData();
                //Indexser Example 
                Customers customers = new Customers();
                var address=customers[712222];
                FactoryCustomer factoryCustomer = new FactoryCustomer();
                ICustomer customer =null;
                customer = factoryCustomer.Create(0);
                customer = factoryCustomer.Create(1);
                I1 i1 = new C();
                I2 i2 = new C();
                // call to method of I1 
                i1.printMethod();

                // call to method of I2 
                i2.printMethod();
                //Console.WriteLine(_PI.ToString());
                technicalscripter t1 = new technicalscripter(" C# | Copy Constructor", 38);

                // Creating object t2 and 
                // copy the data of t1 object 
                // into t2 object 
                technicalscripter t2 = new technicalscripter(t1);

                Console.WriteLine(t2.Data);
                object str1 = 1223;
                if (str1 is string)
                {
                    Console.WriteLine("This is same type.");
                }
                string x = str1 as string;
                Console.ReadLine();
                int OutSideVar = 20;
                SomeFunction(out OutSideVar);
                Method2();
                Console.WriteLine("The main application has exited.!!" );
            }
            catch (Exception ex)
            
            {
                Console.WriteLine(ex.StackTrace.ToString());
                Console.ReadLine();

            }

        }
        static void Function1()
        {
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("Function1 1 Executed  " + i.ToString());
               // Thread.Sleep(4000);
                Console.ReadLine();
            }
        }
        static void Function2()
        {
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("Function2 2 Executed  " + i.ToString());
                //Thread.Sleep(4000);
            }
        }
        static void SomeMethod()
        {
            Console.WriteLine("Starting ......");
            objeAuto.WaitOne();
            Console.WriteLine("Finishing.....");
            Console.WriteLine("Starting ......1");
            objeAuto.WaitOne();
            Console.WriteLine("Finishing.....1");
            Console.WriteLine("Starting ......2");
            objeAuto.WaitOne();
            Console.WriteLine("Finishing.....2");
        }
        static object ParseData(string strData)
        {
            string[] data = new string[4];
            data = strData.Split(' ');
            return new
            {
                FirstName = data[0],
                MiddleName = data[1],
                LastName = data[2],
                PhoneNumber =Convert.ToDouble(data[3])
            };
        }
        static T Cust<T>(object obj,T type)
        {
            return (T)obj;
        }
        static void ParseData(string strData,out string strFirstName,out string strMiddleName,out string strLastName,out double PhoneNumber)
        {
            string[] data = new string[4];
            data = strData.Split(' ');
            strFirstName = data[0];
            strMiddleName = data[1];
            strLastName = data[2];
            PhoneNumber =Convert.ToDouble(data[3]);
        }
        static Tuple<string, string, string, double> ParseDataUsingTuple(string strData)
        {
            string[] data = new string[4];
            data = strData.Split(' ');
            return Tuple.Create<string, string, string, double>(
                                data[0],
                                data[1],
                                data[2],
                                Convert.ToDouble(data[3]));
        }

        static void SomeFunction(out int InsideVar)
        {
            InsideVar = 0;
            InsideVar = InsideVar + 10;
        }
        static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }
        public static void Method1()
        {
            try
            {
                throw new Exception("This is from Method1");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
public class Class1
{
    private Class1()
    {

    }
    public static string getData()
    {
        return "Hello Manash";
    }
}
//public class Class2:Class1
//{
//    private Class2()
//    {

//    }
//}
        class technicalscripter
        {

            // variables 
            private string topic_name;
            private int article_no;

            // parametrized constructor 
            public technicalscripter(string topic_name, int article_no)
            {
                this.topic_name = topic_name;
                this.article_no = article_no;
            }

            // copy constructor 
            public technicalscripter(technicalscripter tech)
            {
                topic_name = tech.topic_name;
                article_no = tech.article_no;
            }

            // getting the topic name and 
            // number of articles published 
            public string Data
            {

                get
                {
                    return "The name of topic is: " + topic_name +
                        " and number of published article is: " +
                                            article_no.ToString();
                }
            }
        }
/// <summary>
///  Customer is the Type
/// </summary>
public class Customers
{
    /// <summary>
    /// / private fields(_id, _firstName, _lastName), Properties(Id, FirstName, LastName) and GetFullName() method are type members
    /// </summary>

    #region Private Fields

    private int _id;
    private string _firstName;
    private string _lastName;
    #endregion
    public List<Address> addresses { get; set; }
    public Customers()
    {
        this.addresses = new List<Address>();
        addresses.Add(new Address
        {
            PinCode = 712222,
            Street = "S.S. Bose Sarani",
            PhoneNumber="796456213"
        });
        addresses.Add(new Address
        {
            PinCode = 712223,
            Street = "A.A Road",
            PhoneNumber = "895454213"
        });
        addresses.Add(new Address
        {
            PinCode = 712245,
            Street = "A.R.T. Road",
            PhoneNumber = "789456123"
        });
    }
    #region Properties

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    #endregion

    #region Methods
    public string GetFullName()
    {
        return this._firstName + " " + this._lastName;
    }
    #endregion
    public Address this[int PinCode]
    {
        get
        {
            foreach(Address o in addresses)
            {
                if(o.PinCode==PinCode)
                {
                    return o;
                }
            }
            return null;
        }

    }
    public Address this[string PhoneNumber]
    {
        get
        {
            foreach (Address o in addresses)
            {
                if (o.PhoneNumber == PhoneNumber)
                {
                    return o;
                }
            }
            return null;
        }
    }
}
public class Address
{
    public string  Street { get; set; }
    public int PinCode { get; set; }
    public string PhoneNumber { get; set; }

}
interface I1
{
    
    void printMethod();
}

interface I2
{
    void printMethod();
}

// class C implements two interfaces 
class C : I1, I2
{

    // Explicitly implements method of I1 
    void I1.printMethod()
    {
        Console.WriteLine("I1 printMethod");
    }

    // Explicitly implements method of I2 
    void I2.printMethod()
    {
        Console.WriteLine("I2 printMethod");
    }
}


