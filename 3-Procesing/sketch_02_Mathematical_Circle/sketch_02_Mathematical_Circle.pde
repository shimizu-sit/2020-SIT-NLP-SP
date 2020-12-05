size(500, 500);
background(255);
strokeWeight(5);
smooth();

float radius = 150;
int centerX = width/2;
int centerY = height/2;

noFill();
stroke(30, 80);
ellipse(centerX, centerY, radius*2, radius*2);

stroke(20, 50, 70);
float x, y;

for(float ang = 0; ang <= 360; ang += 5) {
  float rad = radians(ang);
  x = centerX + (radius * cos(rad));
  y = centerY + (radius * sin(rad));
  point(x, y);
}

//save("sketch_02_mathematical_circle.png");
