using System.Text.RegularExpressions;

namespace NguyenThuyDungBTH.Models.Process{
    public class stringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string result = "";
            strInput = strInput.Trim();
            int index = strInput.IndexOf("  ");
            while (index >0)
            {
                strInput = strInput.Replace("  "," ");
            }
            result = strInput;
            return result;
        }

        public string LowerToUpper(string strInput)
         {
             string ltu= "";
             //chuyen sang in hoa
             strInput = strInput.ToUpper();
             ltu = strInput;
             return ltu;
        }
        public string UpperToLower(string strInput)
         {
             string utl = "";
              //chuyen sang in thuong
             strInput = strInput.ToLower();
             utl = strInput;
             return utl;
        }
        public string CapitalizeOneFirstCharacter(string strInput)
         {
            string onefirst = "";
             //viet hoa chu cai dau tien cua chuoi
             string firstCharacter = strInput.Substring(0,1).ToUpper();
             strInput = firstCharacter + strInput.Substring(1);
             onefirst = strInput;
             return onefirst;
        }
         public string CapitalizeFirstCharacter(string strInput)
         {
             
             //viet hoa chu cai dau tien cua chuoi
             string first = "";
            string[] chuoi = strInput.Split(" ");
            for(int i=0;i<chuoi.Length;i++)
            {
                if(chuoi[i] != "")
                {
                    chuoi[i] = CapitalizeOneFirstCharacter(chuoi[i]);
                }
            }
            first = String.Join(" ", chuoi);
             return first;
            //string FirtChar = chuoi[i].Substring(0, 1);
            //string OtherChar = chuoi[i].Substring(1);
            // chuoi[i] = FirtChar.ToUpper() + OtherChar.ToLower();
            // de tach ra moi mang( tach ra moi chu)
            //capifirt += chuoi[i] + " ";
        }
        public string RemoveVietnameseAccents (string strInput)
        {
            string Result ="";
            // x??a d???u ti???ng vi???t
            string chuoi = strInput.ToLower();
            chuoi = Regex.Replace(chuoi,"??|??|???|??|???|??|???|???|???|???|???|??|???|???|???|???|???|/g","a");
            chuoi = Regex.Replace(chuoi,"??","d");
            chuoi = Regex.Replace(chuoi,"??|??|???|???|???|??|???|???|???|???|???/g","e");
            chuoi = Regex.Replace(chuoi,"??|??|???|??|???/g","i");
            chuoi = Regex.Replace(chuoi,"??|??|???|??|???|??|???|???|???|???|???|??|???|???|???|???|???/g","o");
            chuoi = Regex.Replace(chuoi,"??|??|??|???|??|???|??|???|???|???|???|???/g","a");
            chuoi = Regex.Replace(chuoi,"???|??|???|???|???/g","a");
            return Result;
        }
    }
}