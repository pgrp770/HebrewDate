namespace HebrewDate
{
    public partial class Form1 : Form
    {


        public Dictionary<string, string> DaysInAWeek = new Dictionary<string, string>()
        {
            { "ראשון", "באחד בשבת" },
            { "שני", "בשני" },
            { "שלישי", "בשלישי" },
            { "רביעי", "ברביעי" },
            { "חמישי", "בחמישי" },
            { "ששי", "בששי" }
        };


        public Dictionary<string, string> DaysInAMonth = new()
        {
            { "1", "יום אחד" },
            { "2", "שני ימים" },
            { "3", "שלשה ימים" },
            { "4", "ארבעה ימים" },
            { "5", "חמשה ימים" },
            { "6", "ששה ימים" },
            { "7", "שבעה ימים" },
            { "8", "שמנה ימים" },
            { "9", "תשעה ימים" },
            { "10", "עשרה ימים" },
            { "11", "אחד עשר יום" },
            { "12", "שנים עשר יום" },
            { "13", "שלשה עשר יום" },
            { "14", "ארבעה עשר יום" },
            { "15", "חמשה עשר יום" },
            { "16", "ששה עשר יום" },
            { "17", "שבעה עשר יום" },
            { "18", "שמנה עשר יום" },
            { "19", "תשעה עשר יום" },
            { "20", "עשרים יום" },
            { "21", "אחד ועשרים יום" },
            { "22", "שנים ועשרים יום" },
            { "23", "שלשה ועשרים יום" },
            { "24", "ארבעה ועשרים יום" },
            { "25", "חמשה ועשרים יום" },
            { "26", "ששה ועשרים יום" },
            { "27", "שבעה ועשרים יום" },
            { "28", "שמנה ועשרים יום" },
            { "29", "תשעה ועשרים יום" },
            { "30", "יום שלשים לחדש פלוני שהוא ראש חודש פלוני" }
        };

        public Dictionary<string, string> Years = new Dictionary<string, string>()
        {
            { "תשפ\"ד", "בשנת חמשת אלפים ושבע מאות ושמנים וארבע" },
            { "תשפ\"ה", "בשנת חמשת אלפים ושבע מאות ושמנים וחמש" },
            { "תשפ\"ו", "בשנת חמשת אלפים ושבע מאות ושמנים ושש" },
            { "תשפ\"ז", "בשנת חמשת אלפים ושבע מאות ושמנים ושבע" },
            { "תשפ\"ח", "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה" },
            { "תשפ\"ט", "בשנת חמשת אלפים ושבע מאות ושמנים ותשע" },
            { "תש\"צ", "בשנת חמשת אלפים ושבע מאות ותשעים" },
            { "תשצ\"א", "בשנת חמשת אלפים ושבע מאות ותשעים ואחד" },
            { "תשצ\"ב", "בשנת חמשת אלפים ושבע מאות ותשעים ושנים" },
            { "תשצ\"ג", "בשנת חמשת אלפים ושבע מאות ותשעים ושלש" },
    

        };
          
        public RepositoryXml xml = new RepositoryXml();

        public Form1()
        {
            InitializeComponent();





        }

        public void ClearComboBoxes()
        {
            comboBoxDaysInAMonth.Text = "";
            comboBoxDaysInAWeek.Text = "";
            comboBoxMonth.Text = "";
            comboBoxYear.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "" || comboBoxMonth.Text == "" || comboBoxDaysInAMonth.Text == "" || comboBoxDaysInAWeek.Text == "")
            {
                MessageBox.Show("חלק מהשדת ריקים, כבוד הרב. מלא אותם בבקשה ותנסה לשלוח שוב");
                return;
            }
            string lamed = comboBoxMonth.Text switch {
            "תשרי" => "יום שלשים לחודש תשרי שהוא ראש חודש מרחשון",              
            "מרחשון" => "יום שלשים לחודש מרחשון שהוא ראש חודש כסלו",
            "כסלו" => "יום שלשים לחודש כסלו שהוא ראש חודש טבת",
            "טבת" => "יום שלשים לחודש טבת שהוא ראש חודש שבט",
            "שבט" => "יום שלשים לחודש שבט שהוא ראש חודש אדר",
            "אדר" => "יום שלשים לחודש אדר שהוא ראש חודש ניסן",
            "אדר הראשון" => "יום שלשים לחודש אדר הראשון שהוא ראש חודש אדר השני",
            "אדר השני" => "יום שלשים לחודש אדר השני שהוא ראש חודש ניסן",
            "ניסן" => "יום שלשים לחודש ניסן שהוא ראש חודש אייר",
            "אייר" => "יום שלשים לחודש אייר שהוא ראש חודש סיון",
            "סיון" => "יום שלשים לחודש סיון שהוא ראש חודש תמוז",
            "תמוז" => "יום שלשים לחודש תמוז שהוא ראש חודש אב",
            "אב" => "יום שלשים לחודש אב שהוא ראש חודש אלול",
            "אלול" => "יום שלשים לחודש אלול שהוא ראש חודש תשרי"
            };


            string date = comboBoxDaysInAMonth.Text switch
            {
                "30" => $"{DaysInAWeek[comboBoxDaysInAWeek.Text]} {lamed} {Years[comboBoxYear.Text]}",
                _ => $"{DaysInAWeek[comboBoxDaysInAWeek.Text]} {DaysInAMonth[comboBoxDaysInAMonth.Text]} לירח {comboBoxMonth.Text} {Years[comboBoxYear.Text]}"
            };

            
            MessageBox.Show(date);
            xml.AddNewQuery(new Query()
            {
                Day = comboBoxDaysInAWeek.Text,
                DayMonth = comboBoxDaysInAMonth.Text,
                Month = comboBoxMonth.Text,
                Year = comboBoxYear.Text,
                Result = date
            });
            ClearComboBoxes();
            




            
        }
    }
}
