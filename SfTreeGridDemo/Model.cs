using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRelationalCollection
{
    class PersonInfo : NotificationObject, INotifyDataErrorInfo
    {
        #region Private Fields

        private static int _globalId = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private bool _likesCake;
        private string _cake = String.Empty;
        private DateTime _dob;
        private string _eyecolor;
        private ObservableCollection<PersonInfo> _children;

        //private ObservableCollection<PersonInfo1> _children;

        #endregion Private Fields

        #region Public Properties

        // /// <summary>
        // /// Gets or sets the children.
        // /// </summary>
        // /// <value>The children.</value>
        //// [Display(AutoGenerateField = false, Description = "Children field is not generated in UI")]
        public ObservableCollection<PersonInfo> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
                RaisePropertyChanged("Children");
            }
        }

        //public ObservableCollection<PersonInfo1> Children
        //{
        //    get
        //    {
        //        return _children;
        //    }
        //    set
        //    {
        //        _children = value;
        //        RaisePropertyChanged("Children");
        //    }
        //}


        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        // [Bindable(false)]
        [Range(100, 300, ErrorMessage = "The “ID” field can range from 100 to 300.")]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        [Required]
        [StringLength(5)]
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        [Display(AutoGenerateField = false)]
        /// <summary>
        /// Gets or sets a value indicating whether [likes cake].
        /// </summary>
        /// <value><c>true</c> if [likes cake]; otherwise, <c>false</c>.</value>
        public bool LikesCake
        {
            get
            {
                return _likesCake;
            }
            set
            {
                _likesCake = value;
                RaisePropertyChanged("LikesCake");
            }
        }

        /// <summary>
        /// Gets or sets the cake.
        /// </summary>
        /// <value>The cake.</value>
        public string Cake
        {
            get
            {
                return _cake;
            }
            set
            {
                _cake = value;
                RaisePropertyChanged("Cake");
            }
        }

        /// <summary>
        /// Gets or sets the DOB.
        /// </summary>
        /// <value>The DOB.</value>
        public DateTime DOB
        {
            get
            {
                return _dob;
            }
            set
            {
                _dob = value;
                RaisePropertyChanged("DOB");
            }
        }

        /// <summary>
        /// Gets or sets the color of my eye.
        /// </summary>
        /// <value>The color of my eye.</value>
        public string MyEyeColor
        {
            get
            {
                return _eyecolor;
            }
            set
            {
                _eyecolor = value;
                RaisePropertyChanged("MyEyeColor");
            }
        }

        #endregion

        #region Constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        public PersonInfo()
            : this("Enter FirstName", "Enter LastName", "Enter EyeColor", new DateTime(2008, 10, 26), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="eyecolor">The eyecolor.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="maxGenerations">The max generations.</param>
        // public PersonInfo(string firstName, string lastName, string eyecolor, DateTime dob, ObservableCollection<PersonInfo1> child)
        public PersonInfo(string firstName, string lastName, string eyecolor, DateTime dob, ObservableCollection<PersonInfo> child)
        {
            FirstName = firstName;
            LastName = lastName;
            MyEyeColor = eyecolor;
            LikesCake = true;
            Cake = "Chocolate";
            DOB = dob;
            Id = _globalId++;
            Children = child;
        }

        #endregion Constructors

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            return null;
        }

        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get
            {
                if (FirstName == "Name")
                    return true;
                return false;
            }
        }
    }



    class PersonInfo1 : NotificationObject
    {
        #region Private Fields

        private static int _globalId = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private bool _likesCake;
        private string _cake = String.Empty;
        private DateTime _dob;
        private string _eyecolor;
        private ObservableCollection<PersonInfo1> _children;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        public ObservableCollection<PersonInfo1> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
                RaisePropertyChanged("Children");
            }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [likes cake].
        /// </summary>
        /// <value><c>true</c> if [likes cake]; otherwise, <c>false</c>.</value>
        public bool LikesCake
        {
            get
            {
                return _likesCake;
            }
            set
            {
                _likesCake = value;
                RaisePropertyChanged("LikesCake");
            }
        }

        /// <summary>
        /// Gets or sets the cake.
        /// </summary>
        /// <value>The cake.</value>
        public string Cake
        {
            get
            {
                return _cake;
            }
            set
            {
                _cake = value;
                RaisePropertyChanged("Cake");
            }
        }

        ///// <summary>
        ///// Gets or sets the DOB.
        ///// </summary>
        ///// <value>The DOB.</value>
        //public DateTime DOB
        //{
        //    get
        //    {
        //        return _dob;
        //    }
        //    set
        //    {
        //        _dob = value;
        //        RaisePropertyChanged("DOB");
        //    }
        //}

        /// <summary>
        /// Gets or sets the color of my eye.
        /// </summary>
        /// <value>The color of my eye.</value>
        public string MyEyeColor
        {
            get
            {
                return _eyecolor;
            }
            set
            {
                _eyecolor = value;
                RaisePropertyChanged("MyEyeColor");
            }
        }

        #endregion

        #region Constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        public PersonInfo1()
            : this("Enter FirstName", "Enter LastName", "Enter EyeColor", new DateTime(2008, 10, 26), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="eyecolor">The eyecolor.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="maxGenerations">The max generations.</param>
        public PersonInfo1(string firstName, string lastName, string eyecolor, DateTime dob, ObservableCollection<PersonInfo1> child)
        {
            FirstName = firstName;
            LastName = lastName;
            MyEyeColor = eyecolor;
            LikesCake = true;
            Cake = "Chocolate";
            //DOB = dob;
            Id = _globalId++;
            Children = child;
        }

        #endregion Constructors
    }
}
