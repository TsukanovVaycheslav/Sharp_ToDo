using System;
using System.ComponentModel;

namespace С_Sharp_____WPF_TODO.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

       // [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
      //  [JsonProperty(PropertyName = "isDone")]

        
        public bool isDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("isDone");
            }
        }

     //   [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
