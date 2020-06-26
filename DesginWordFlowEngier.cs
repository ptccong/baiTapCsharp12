using System;
using System.Collections.Generic;

namespace DesginWordFlow 
{
	class WordFlowEngier
	{
		static void Main(string[] args)
        {
            WorkFlowEngine w = new WorkFlowEngine();
            w.AddWorkFlow(new uploadVideo());
            w.AddWorkFlow(new sendEmail());
            w.AddWorkFlow(new callWebService());
            w.AddWorkFlow(new changeStatus());
            w.Run();
            Console.WriteLine();
        }
	}
	public interface IActivity
    {
		void Execute();
    }
	public interface IWorkflow
    {
		void add(IActivity activity);
		void remove(IActivity activity);
    }
	class Workflow : IWorkflow
    {
		public void add(IActivity activity)
        {
			throw new NotImplementedException();
        }
		public void remove(IActivity activity)
        {
			throw new NotImplementedException();
        }
    }
	class uploadVideo : IActivity
    {
		public void Execute()
        {
			Console.WriteLine("Đang up video");
        }
    }
	class sendEmail : IActivity
    {
		public void Execute()
        {
            Console.WriteLine("Đang gửi video");
        }
    }
    class callWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("kết nối với dịch vụ của web");
        }
    }
    class changeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Đang thay đổi trạng thái ");
        }
    }
    class WorkFlowEngine
    {
        private List<IActivity> ac;
        public WorkFlowEngine()
        {
            ac = new List<IActivity>();
        }
        public void AddWorkFlow(IActivity iObject)
        {
            ac.Add(iObject);
        }
        public void RemoveWorkFlow(IActivity iObject)
        {
            ac.Remove(iObject);
        }
        public void Run()
        {
            foreach(IActivity i in ac)
            {
                i.Execute();
            }
        }
    }

}
