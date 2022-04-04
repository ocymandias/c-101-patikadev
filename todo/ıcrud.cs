using System;

namespace todo
{
    public interface ICrud
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetLists();
    }
}