// L293D
int IN1 = 7;
int IN2 = 8;
int IN3 = 13;
int IN4 = 12;
int ENA = 9;
int ENB = 11;

int MotorSpeedA = 200;
int MotorSpeedB = 200;
int MotorTurnA = 255;
int MotorTurnB = 255;

// Sensors
int s1 = 4;
int s2 = 5;
int s3 = 6;
boolean sens1, sens2, sens3;

// UltraSonic
int PingPin = A1;
int EchoPin = A0;
unsigned long cm, duration, CheckDistance;

// Read Character
char ch;

bool letsGo = true, firstTime = true;
int irTurningCounter = 0;


/* ================================================= */


void setup() 
{
  
  Serial.begin(9600);

  pinMode(s1, INPUT);
  pinMode(s2, INPUT);
  pinMode(s3, INPUT);

  pinMode(PingPin, OUTPUT);
  pinMode(EchoPin, INPUT);

  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
  
  analogWrite(ENA, LOW);
  analogWrite(ENB, LOW);
  
}

void loop() 
{
  
  if (Serial.available() > 0) 
  {
    ch = (char) Serial.read();

    switch(ch)
    {
    case 'W' : 
      MoveForward();
      break;

    case 'S' :
      MoveBackward();
      break;
      
    case 'A' :
      TurnLeft();
      break;  
      
    case 'D' :
      TurnRight();
      break;
    
    case 'Q' :
      MoveTopLeft();
      break;
      
    case 'E' :
      MoveTopRight();
      break;
    
    case 'Z' :
      MoveBottomLeft();
      break;
    
    case 'C' :
      MoveBottomRight();
      break;

    case 'P' :
      MotorsOff();
      break;
      
    case 'U' :
      AutoUltraDrive();
      break;
      
    case 'I' :
      AutoIRDrive();
      break;
      
    case '/':
      if (MotorSpeedA == 175 && MotorSpeedB == 175 )
      {
        MotorSpeedA += 80;
        MotorSpeedB += 80;
      }
      else
      {
        MotorSpeedA += 40;
        MotorSpeedB += 40;
      }
      break;
      
    case '.' :
      MotorSpeedA = 215;
      MotorSpeedB = 215;
      break;
      
    case ',' :
      if (MotorSpeedA == 255 && MotorSpeedB == 255 )
      { 
        MotorSpeedA -= 80;
        MotorSpeedB -= 80;
      }
      else
      {  
        MotorSpeedA -= 40;
        MotorSpeedB -= 40;
      }
      break;
      
      case ']' :
        MotorTurnA = 220;
        MotorTurnB = 220;
        break;
      
      case '[' :
        MotorTurnA = 255;
        MotorTurnB = 255;
        break;
      
      case 'F' :
        BTMoveForward();
        break;
        
      case 'G' :
        BTMoveBackward();
        break;
        
      case 'H' :
        BTTurnRight();
        break;
        
      case 'J' :
        BTTurnLeft();
        break;

      case 'o' :
        irTurningCounter = 0;
        break;
    }
  }
  
}


/* ================================================= */


// Function for Moving Forward
void MoveForward()
{
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  analogWrite(ENA, MotorSpeedA);
  analogWrite(ENB, MotorSpeedB);
}

// Function for Moving Backward
void MoveBackward() 
{
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);  
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  analogWrite(ENA, MotorSpeedA);
  analogWrite(ENB ,MotorSpeedB);
}

// Function for Turning Right
void TurnRight() 
{
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  if (MotorTurnA == 220)
  {
  analogWrite(ENA, 0);
  analogWrite(ENB, MotorTurnB + 35);
  }
  else
  {
    analogWrite(ENA, MotorTurnA);
    analogWrite(ENB, MotorTurnB);
  }
}

// Function For Turning Left
void TurnLeft() 
{
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  if (MotorTurnA == 220)
  {
  analogWrite(ENA, MotorTurnA + 35);
  analogWrite(ENB, 0);
  }
  else
  {
    analogWrite(ENA, MotorTurnA);
    analogWrite(ENB, MotorTurnB);
  }
}

// Fuction For Moving Top Right
void MoveTopRight()
{
  digitalWrite(IN1, HIGH );
  digitalWrite(IN2, LOW );
  digitalWrite(IN3, HIGH );
  digitalWrite(IN4, LOW );
  analogWrite(ENA,MotorTurnA - 130);
  analogWrite(ENB,MotorTurnB);

}

// Fuction For Moving Top Left
void MoveTopLeft() 
{
  digitalWrite(IN1, HIGH );
  digitalWrite(IN2, LOW );
  digitalWrite(IN3, HIGH );
  digitalWrite(IN4, LOW );
  analogWrite(ENA,MotorTurnA);
  analogWrite(ENB,MotorTurnB - 165);
}

// Fuction For Moving Bottom Right
void MoveBottomRight() 
{
  digitalWrite(IN1, LOW );
  digitalWrite(IN2, HIGH );
  digitalWrite(IN3, LOW );
  digitalWrite(IN4, HIGH );
  analogWrite(ENA,MotorTurnA - 130);
  analogWrite(ENB,MotorTurnB);
}

// Fuction For Moving Bottom Left
void MoveBottomLeft() 
{
  digitalWrite(IN1, LOW );
  digitalWrite(IN2, HIGH );
  digitalWrite(IN3, LOW );
  digitalWrite(IN4, HIGH );
  analogWrite(ENA,MotorTurnA);
  analogWrite(ENB,MotorTurnB - 165);
}

// Function For Setting Motors Off
void MotorsOff() 
{
  analogWrite(ENA, LOW);
  analogWrite(ENB, LOW);
}

// Ultrasonic
int UltraSonic() 
{
  digitalWrite(PingPin, LOW);
  delayMicroseconds(2);
  digitalWrite(PingPin, HIGH);
  delayMicroseconds(5);
  digitalWrite(PingPin, LOW);
  duration = pulseIn(EchoPin, HIGH);
  cm = MicroStoCm(duration);
  return cm;
}

// Converting MicroS to CM
unsigned long MicroStoCm(unsigned long MicroS) 
{
  return (MicroS / 29) / 2;
}

// Turning To Auto Ultra Drive Mode
void AutoUltraDrive()
{
  while(Serial.read() == -1)
  {
    UltraSonic();

    if (firstTime)
    {
      firstTime = false;
    }
    else
    {
      if (cm <= 12)
      {
        // while(cm < 10)
        // {
        //  MoveBackward();
        //  delay(20);
        //  UltraSonic();
        // } 
        
        MotorsOff();
        delay(200);
        
        // MotorTurnA = 105;
        // MotorTurnB = 105;
        
        // while(MotorTurnA < 255)
        // {
        //   TurnRight();
        //   delay(100);
        //   MotorTurnA += 10;
        //   MotorTurnB += 10;
        // }
        
        TurnRight();
        delay(400);
        
        // MotorsOff();
        // delay(30);
        
        // CheckDistance = UltraSonic();
        
        // TurnLeft();
        // delay(780);
        // MotorsOff();
        // delay(10);
        
        // if (UltraSonic() >= 15)
        // {
        //   MoveForward();
        //   delay(40);
        // }
        // else
        // {
        //    TurnLeft();
        //    delay(800);
        // }
        // if (UltraSonic() >= 15)
        // {
        //    MoveForward();
        //    delay(40);
        // }
        // else
        // {
        //   TurnLeft();
        //   delay(450);
        // }
        // if (UltraSonic() >= 15)
        // {
        //   MoveForward();
        //   delay(40);
        // }
        // else
        // {
        //   MotorsOff();
        //   delay(50);
        // }
      }
      else
      {
        MoveForward();
        delay(40);
      }
    } 
  }
}

// Turning To Auto IR Drive Mode
void AutoIRDrive()
{
    while(Serial.read() == -1)
    {
      SensorsDigitalRead();
      
      if (letsGo)
      {
        if (!sens1 && !sens2 && !sens3)
        {
          // MotorsOff();
          // delay(20);
          if (irTurningCounter == 4)
          {
            MotorsOff();
            delay(20);
            do
            {
              TurnLeft();
              delay(5);
              SensorsDigitalRead();
              if (sens1 && !sens2 && sens3)
                letsGo = true;
              else
                letsGo = false;
           
            } while(!sens1);
          }
          else if (irTurningCounter == 5)
          {
            MotorsOff();
            delay(20);
            do
            {
            TurnRight();
            delay(5);
            SensorsDigitalRead();
            if (sens1 && !sens2 && sens3)
              letsGo = true;
            else
              letsGo = false;
             
            } while(!sens3);
          }
          else
          {
            MoveForward();
            delay(25);
          }
          irTurningCounter++;
        }
        else if (sens1 && sens2 && sens3)
        {
          // MotorsOff();
          // delay(20);
          MoveForward();
          delay(25);
        }
        else if (!sens1 && sens2 && !sens3)
        {
          // MotorsOff();
          // delay(20);
          MoveForward();
          delay(25);
        }
      }
      if (sens1 && !sens2 && sens3)
        {
          MoveForward();
          delay(25);
          letsGo = true;
        }
      else if (!sens1 && !sens2 && sens3)
      {
        MotorsOff();
        delay(20);
        do
        {
          TurnLeft();
          delay(5);
          SensorsDigitalRead();
          if (sens1 && !sens2 && sens3)
            letsGo = true;
          else
           letsGo = false;
           
        } while(!sens1);
      }
      else if (sens1 && !sens2 && !sens3)
      {
        MotorsOff();
        delay(20);
         do
         {
         TurnRight();
         delay(5);
         SensorsDigitalRead();
         
         if (sens1 && !sens2 && sens3)
           letsGo = true;
         else
           letsGo = false;
           
         } while(!sens3);
      }
      else if (sens1 && sens2 && !sens3)
      {
        MotorsOff();
        delay(20);
         do
         {
         TurnRight();
         delay(5);
         SensorsDigitalRead();
         if (sens1 && !sens2 && sens3)
           letsGo = true;
         else
           letsGo = false;
         } while(!sens3);
      }
      else if (!sens1 && sens2 && sens3)
      {
        MotorsOff();
        delay(20);
         do
         {
         TurnLeft();
         delay(5);
         SensorsDigitalRead();
         if (sens1 && !sens2 && sens3)
           letsGo = true;
         else
           letsGo = false;
         } while(!sens1);
      }
    }
}

// Sensors
void SensorsDigitalRead() 
{
  sens1 = digitalRead(s1);
  sens2 = digitalRead(s2);
  sens3 = digitalRead(s3);
}

// Serial Printing
/*void SerialPrint()
{
  SensorsDigitalRead();
  UltraSonic();
  Serial.print("S1= ");
  Serial.print(sens1);
  Serial.print(" S2= ");
  Serial.print(sens2);
  Serial.print(" S3= ");
  Serial.println(sens3);
  Serial.print("Distance Is= ");
  Serial.println(cm);
  delay(200);
}
*/

// Function for Moving Forward - Second Bluetooth :D
void BTMoveForward()
{
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  
  analogWrite(ENA, MotorSpeedA);
  analogWrite(ENB, MotorSpeedB);
  delay(100);
  MotorsOff();
}

// Function for Moving Backward - Second Bluetooth :D
void BTMoveBackward() 
{
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);  
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  
  analogWrite(ENA, MotorSpeedA);
  analogWrite(ENB ,MotorSpeedB);
  delay(100);
  MotorsOff();
}

// Function for Turning Right - Second Bluetooth :D
void BTTurnRight() 
{
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  
  if (MotorTurnA == 220)
  {
  analogWrite(ENA, 0);
  analogWrite(ENB, MotorTurnB);
  }
  else
  {
    analogWrite(ENA, MotorTurnA);
    analogWrite(ENB, MotorTurnB);
  }
  delay(100);
  MotorsOff();
}

// Function For Turning Left - Second Bluetooth :D
void BTTurnLeft() 
{
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  
  if (MotorTurnA == 220)
  {
  analogWrite(ENA, MotorTurnA);
  analogWrite(ENB, 0);
  }
  else
  {
    analogWrite(ENA, MotorTurnA);
    analogWrite(ENB, MotorTurnB);
  }
  delay(100);
  MotorsOff();
}
