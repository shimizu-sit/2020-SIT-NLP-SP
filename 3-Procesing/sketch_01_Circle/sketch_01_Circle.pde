size(500, 500);
background(255);
strokeWeight(5);
smooth();

float radius = 150;
int centerX = width/2;
int centerY = height/2;

noFill();
ellipse(centerX, centerY, radius*2, radius*2);

save("sketch_01_circle.png");
