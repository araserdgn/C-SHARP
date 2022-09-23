using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV
{
	// Include namespace system

	// Csharp program for
	// Prefix to infix conversion

	// Stack Node
	public class StackNode
	{
		public String data;
		public StackNode next;
		public StackNode(String data, StackNode top)
		{
			this.data = data;
			this.next = top;
		}
	}
	public class MyStack
	{
		public StackNode top;
		public int count;
		public MyStack()
		{
			this.top = null;
			this.count = 0;
		}
		// Returns the number of element in stack
		public int size()
		{
			return this.count;
		}
		public bool isEmpty()
		{
			if (this.size() > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		// Add a new element in stack
		public void push(String data)
		{
			// Make a new stack node
			// And set as top
			this.top = new StackNode(data, this.top);
			// Increase node value
			this.count++;
		}
		// Add a top element in stack
		public String pop()
		{
			var temp = "";
			if (this.isEmpty() == false)
			{
				// Get remove top value
				temp = this.top.data;
				this.top = this.top.next;
				// Reduce size
				this.count--;
			}
			return temp;
		}
		// Used to get top element of stack
		public String peek()
		{
			if (!this.isEmpty())
			{
				return this.top.data;
			}
			else
			{
				return "";
			}
		}
	}
	public class Conversion
	{
		// Check operator
		public bool isOperator(char text)
		{
			if (text == '+' || text == '-' ||
				text == '*' || text == '/' ||
				text == '^' || text == '%')
			{
				return true;
			}
			return false;
		}
		// Check operands
		public bool isOperands(char text)
		{
			if ((text >= '0' && text <= '9') ||
				(text >= 'a' && text <= 'z') ||
				(text >= 'A' && text <= 'Z'))
			{
				return true;
			}
			return false;
		}
		// Converting the given prefix expression to 
		// infix expression
		public void prefixToinfix(String prefix)
		{
			// Get the size
			var size = prefix.Length;
			// Create stack object
			var s = new MyStack();
			// Some useful variables which is using 
			// of to storing current result
			var auxiliary = "";
			var op1 = "";
			var op2 = "";
			var isValid = true;
			for (var i = size - 1; i >= 0; i--)
			{
				// Check whether given prefix location
				// at [i] is an operator or not
				if (this.isOperator(prefix[i]))
				{
					// When operator exist
					// Check that two operands exist or not
					if (s.size() > 1)
					{
						op1 = s.pop();
						op2 = s.pop();
						auxiliary = "(" + op1 + prefix[i] + op2 + ")";
						// Add into stack
						s.push(auxiliary);
					}
					else
					{
						isValid = false;
					}
				}
				else if (this.isOperands(prefix[i]))
				{
					// When get valid operands
					auxiliary = prefix[i].ToString();
					// Add into stack
					s.push(auxiliary);
				}
				else
				{
					// Invalid operands or operator
					isValid = false;
				}
			}
			if (isValid == false)
			{
				// When have something wrong
				Console.WriteLine("Invalid Prefix : " + prefix);
			}
			else
			{
				// Display calculated result
				Console.WriteLine(" Prefix : " + prefix);
				Console.WriteLine(" Infix  : " + s.pop());
			}
		}
		public static void Main(String[] args)
		{
			var task = new Conversion();
			var prefix = "+*ab^cd";
			task.prefixToinfix(prefix);
			prefix = "-+*^%adcex*y^ab";
			task.prefixToinfix(prefix);

			Console.ReadLine();
		}
	}

}

