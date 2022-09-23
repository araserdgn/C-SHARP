using State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifiadState modifiadState = new ModifiadState();
            modifiadState.DoAction(context);

            DeletedState deletedState = new DeletedState();
            deletedState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            Console.ReadLine();
        }
    }

    interface IState
    {
        void DoAction(Context context);
    }

    class ModifiadState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Modified");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Added";
        }
    }
    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Deleted");
            context.setState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }
    }

    class AddState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : added");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Added";
        }
    }

    class Context //*//
    {
        private IState _state;
        public void setState(IState state)
        {
            _state = state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}

