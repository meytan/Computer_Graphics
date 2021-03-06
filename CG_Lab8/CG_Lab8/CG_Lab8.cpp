// CG_Lab8.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include <stdlib.h>
#include "glut.h"
enum
{
	PUNKTY, LINIE, LAMANE, LAMANA_ZAM, WSTEGA, WACHLARZ, CZWORO, WSTEGA_CZWORO, TROJKAT, KWADRAT, EXIT
};
int object;
void Display()
{
	glClearColor(1.0, 1.0, 1.0, 1.0);
	glClear(GL_COLOR_BUFFER_BIT);
	glMatrixMode(GL_MODELVIEW);
	glColor3f(1.0, 0.0, 0.0);
	switch (object)
	{
		// trojkat
	case TROJKAT: {
		glBegin(GL_TRIANGLES);
		// kolejne wierzchołki wielokąta
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 1.0, 0.0);
		glVertex3f(1.0, 1.0, 0.0);
		glEnd();
		break; }
				  // kwadrat
	case KWADRAT: {
		glBegin(GL_POLYGON);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 1.0, 0.0);
		glVertex3f(1.0, 1.0, 0.0);
		glVertex3f(1.0, 0.0, 0.0);
		glEnd();
		break; }
	case PUNKTY: {
		glPointSize(10.0f);
		glBegin(GL_POINTS);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glEnd();
		break; }
	case LINIE: {
		glBegin(GL_LINES);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glEnd();
		break; }
	case LAMANE: {
		glBegin(GL_LINE_STRIP);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glEnd();
		break; }
	case LAMANA_ZAM: {
		glBegin(GL_LINE_LOOP);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glEnd();
		break; }
	case WSTEGA: {
		glBegin(GL_TRIANGLE_STRIP);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, -0.5, 0.0);
		glVertex3f(-0.5, -0.5, 0.0);
		
		glEnd();
		break; }
	case WACHLARZ: {
		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glVertex3f(-0.5, 0.0, 0.0);
		glVertex3f(0.5, -1.0, 0.0);
		glEnd();
		break; }
	case CZWORO: {
		glBegin(GL_QUADS);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glEnd();
		break; }
	case WSTEGA_CZWORO: {
		glBegin(GL_QUAD_STRIP);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 0.5, 0.0);
		glVertex3f(0.5, 0.5, 0.0);
		glVertex3f(0.5, 0.0, 0.0);
		glVertex3f(0.1, 0.0, 0.0);
		glVertex3f(0.0, -0.5, 0.0);
		glVertex3f(-0.5, -0.5, 0.0);
		glVertex3f(-0.5, 0.0, 0.0);
		glEnd();
		break; }
	}
	glFlush();
	glutSwapBuffers();
}
void Reshape(int width, int height)
{
	Display();
}
void Menu(int value)
{
	switch (value)
	{
		// TROJKAT
	case TROJKAT:
		object = TROJKAT;
		Display();
		break;
		// KWADRAT
	case KWADRAT:
		object = KWADRAT;
		Display();
		break;
	case PUNKTY:
		object = PUNKTY;
		Display();
		break;
	case LINIE:
		object = LINIE;
		Display();
		break;
	case LAMANE:
		object = LAMANE;
		Display();
		break;
	case LAMANA_ZAM:
		object = LAMANA_ZAM;
		Display();
		break;
	case WSTEGA:
		object = WSTEGA;
		Display();
		break;
	case WSTEGA_CZWORO:
		object = WSTEGA_CZWORO;
		Display();
		break;
	case WACHLARZ:
		object = WACHLARZ;
		Display();
		break;
	case CZWORO:
		object = CZWORO;
		Display();
		break;

		// wyjście
	case EXIT:
		exit(0);
	}
}
int main(int argc, char * argv[])
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(600, 600);
	glutCreateWindow("Pierwszy program");
	glutDisplayFunc(Display);
	glutReshapeFunc(Reshape);
	glutCreateMenu(Menu);
	glutAddMenuEntry("Trojkat", TROJKAT);
	glutAddMenuEntry("Kwadrat", KWADRAT);
	glutAddMenuEntry("Punkty", PUNKTY);
	glutAddMenuEntry("Linie", LINIE);
	glutAddMenuEntry("Lamane", LAMANE);
	glutAddMenuEntry("Lamane Zamkniete", LAMANA_ZAM);
	glutAddMenuEntry("Czworokat", CZWORO);
	glutAddMenuEntry("Wstega czworokatow", WSTEGA_CZWORO);
	glutAddMenuEntry("Wstega trojkatow", WSTEGA);
	glutAddMenuEntry("Wachlarz trojkatow", WACHLARZ);
	glutAddMenuEntry("wyjscie", EXIT);
	glutAttachMenu(GLUT_RIGHT_BUTTON);
	glutMainLoop();
	return 0;
}