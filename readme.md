# Calculator

by ณัฐวุฒิ จันทร์สนิท,
673450036-4,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}

### รับข้อมูล

ตัวอย่าง
{
 var inputn1 = n1.Text;
 var inputn2 = n2.Text;
}
### แปลงชนิดของข้อมูล

ตัวอย่าง
{
 double num1 = double.Parse(inputn1);
 double num2 = double.Parse(inputn2);
 double sum = num1 + num2;
}
### คำนวนผลลัพท์

ตัวอย่าง
{
 double sum = num1 + num2;
}
### แสดงผล

ตัวอย่าง
{
r.Text = sum.ToString();
}
## ปุ่มลบ
        private void button2_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // แปลงข้อความเป็นจำนวนเต็มแล้วลบกัน
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 - num2;

            // แสดงผลลัพธ์ใน text box r
            r.Text = sum.ToString();
        }
## ปุ่มคูณ
        private void button3_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // แปลงข้อความเป็นจำนวนเต็มแล้วคูณกัน
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 * num2;

            // แสดงผลลัพธ์ใน text box r
            r.Text = sum.ToString();
        }
## ปุ่มหาร
        private void button4_Click(object sender, EventArgs e)
        {
            var inputn1 = n1.Text;
            var inputn2 = n2.Text;

            // แปลงข้อความเป็นจำนวนเต็มแล้วหารกัน
            double num1 = double.Parse(inputn1);
            double num2 = double.Parse(inputn2);
            double sum = num1 / num2;

            // แสดงผลลัพธ์ใน text box r
            r.Text = sum.ToString();
        }
## ปุ่มลบข้อมูล
        private void button5_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            r.Text = "";
        }