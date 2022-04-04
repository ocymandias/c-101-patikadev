using System;
using System.Collections.Generic;

namespace todo
{

    class Card
    {
        private string _title;
        private string _content;
        private Employee _employee;
        private Size _size;
        private State _state;

        public string Title
        { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public Employee Employee { get => _employee; set => _employee = value; }
        public Size Sizee { get => _size; set => _size = value; }
        internal State State1 { get => _state; set => _state = value; }

        static List<Card> cardList = new();
        public Card(string title,
                    string content,
                    Employee employee,
                    Size size, State state)
        {
            _title = title;
            _content = content;
            _employee = employee;
            _size = size;
            _state = state;
        }

        public Card()
        {

        }

        public enum Size
        {
            XS = 1,
            S,

            M,
            L,
            XL
        }

        public enum State
        {
            TODO_LINE,
            IN_PROGRESS_LINE,
            DONE_LIST
        }
    }


}