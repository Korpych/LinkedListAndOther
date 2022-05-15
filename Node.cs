using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_and_S_and_LL
{
    public class Node <T>
    {
        //Data
        public T Data { get; set; }

        //Link
        public Node<T> Next { get; internal set; }

        //Constructor
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
