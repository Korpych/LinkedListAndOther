using System;

namespace R_and_S_and_LL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CatStats();
            //PointS();
            //WineS();
            //WineStorage[] wineArray = new WineStorage[3]
            //    {
            //new WineStorage("Marlborough Sun", "New Zealand"),
            //new WineStorage("Susumaniello", "Italia"),
            //new WineStorage("Cote des Roses", "France"),
            //    };

            //Wine wineList = new Wine(wineArray);
            //foreach (WineStorage p in wineList)
            //    Console.WriteLine(p.nameWine + " " + p.countryWine);
            LinkedList<string> ll = new LinkedList<string>();

            Node<string> a = new Node<string>("aaa");
            ll.AddFirst(a);

            Node<string> b = new Node<string>("bbb");
            ll.AddFirst(b);

            Node<string> c = new Node<string>("ccc");
            ll.AddFirst(c);

            Node<string> d = new Node<string>("ddd");
            ll.AddFirst(d);

            ll.Traverse();

            Console.WriteLine("Add after a");
            ll.addAfter(new Node<string>("xxx"), a);
            ll.Traverse();

            Node<string> target = ll.Find("ddd");
            if (target != null)
            {
                Console.WriteLine("found: " + target.Data);
            }
            else
            {
                Console.WriteLine("foobar");
            }

            Console.WriteLine("\nremoving " + target.Data);
            ll.Remove(target);
            ll.Traverse();
        }

        static void CatStats()
        {
            Cat cat1 = new Cat("Мурзик", "мэйн-кун", "рыжий", 5);
            Cat cat2 = new Cat("Мурзик", "мэйн-кун", "рыжий", 5);

            Console.WriteLine(cat1 == cat2);

            Console.WriteLine(cat1);

            cat1 = cat1 with
            {
                Name = "Шарик"
            };

            Console.WriteLine(cat1);
        }
        
        static void PointS()
        {
            var structPoint = new StructPoint() { X = 10, Y = 10 };
        }
        
        static void WineS()
        {
            var wine = new R_and_S_and_LL.Wine()
            {
                WineColor = WineColor.White,
                WineYear = WineYear.TwentyNineteen
            };

            Console.WriteLine("Wine color is -> " + WineColor.White);
            Console.WriteLine("Wine year is -> " + WineYear.TwentyNineteen);
        }

        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }

        public interface IEnumerator
        {
            bool MoveNext();
            object Current { get; }
            void Reset();
        }
        public class WineStorage
        {
            public WineStorage(string nWine, string cWine)
            {
                this.nameWine = nWine;
                this.countryWine = cWine;
            }

            public string nameWine;
            public string countryWine;
        }

        
        public class Wine : IEnumerable
        {
            private WineStorage[] _wine;
            public Wine(WineStorage[] wArray)
            {
                _wine = new WineStorage[wArray.Length];

                for (int i = 0; i < wArray.Length; i++)
                {
                    _wine[i] = wArray[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public WineEnum GetEnumerator()
            {
                return new WineEnum(_wine);
            }
        }

        
        public class WineEnum : IEnumerator
        {
            public WineStorage[] _wine;

            
            int position = -1;

            public WineEnum(WineStorage[] list)
            {
                _wine = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _wine.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public WineStorage Current
            {
                get
                {
                    try
                    {
                        return _wine[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        

        
    }



} 
