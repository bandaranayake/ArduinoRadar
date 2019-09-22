#include <Servo.h> 
#define trigPin 12
#define echoPin 11
#define servoPin 10

Servo servo; 

void setup() { 
  servo.attach(servoPin); 
  Serial.begin(9600);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
}

void loop(){
  for(int servoAngle = 0; servoAngle <= 180; servoAngle++)
  {                                  
    servo.write(servoAngle);              
    delay(50);
    print(servoAngle);       
  }
  
  for(int servoAngle = 180; servoAngle >= 0; servoAngle--)
  {                                  
    servo.write(servoAngle);              
    delay(50);
    print(servoAngle);       
  }
}

void print(int servoAngle){
  digitalWrite(trigPin, LOW);
  delayMicroseconds(5);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
 
  int duration = pulseIn(echoPin, HIGH);
  int cm = (duration/2) / 29.1;
  Serial.print(servoAngle);
  Serial.print(","); 
  Serial.println(cm);  
}
