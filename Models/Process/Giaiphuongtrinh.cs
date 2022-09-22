namespace NguyenThuyDungBTH.Models.Process
{
    public class Giaiphuongtrinh
    {
        // các bước khai báo 1 phg thức
        //1.xác định kiểu trả về của phương thức
        //2. Xác định các tham số  đầu vào của pt
        //3. xây dựng thân phương thức 
        //4. trả về dữ liệu tg ứng
        public int SumInt (int a, int b)
        {
            return(a+b);
        }
        //xay dung giai phuong trinh bac nhat
        public string GiaiPhuongTrinhBacNhat( double heSoA, double heSoB)
        {
            
            string message = "";
            double x;
            if(heSoA==0){
                if(heSoB==0)
            {
                message ="phuong trinh vo so nghiem";

            }
            else{
                 message ="phuong trinh vo nghiem";

            }

            }
            else{
                x= -heSoB/heSoA;
                message = "phuong trinh co nghiem: " +x;
            }
            return message;
        }
         //Giải phương trình bậc 2
        public string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            string bachai = "";
            double x1; double x2; double x;
            if(a==0)
            {
                bachai = GiaiPhuongTrinhBacNhat(b,c);
            }
            else{
                double delta = b*b-4*a*c;
                if(delta <0)
                {
                    bachai = "Phương trình vô nghiệm";
                }
                else{
                    if(delta == 0)
                    {
                        x= (-b)/(2*a);
                        bachai = "Phương trình có nghiệm kép: x1 = x2= " + x ;
                    }
                    else{
                        x1 = (-b+Math.Sqrt(delta))/(2*a);
                        x2 = (-b-Math.Sqrt(delta))/(2*a);
                        bachai = "Phương trình có 2 nghiệm: x1 = " + x1 +", x2= "+ x2;
                    }
                }
            }
            return bachai;
        }
    }
}