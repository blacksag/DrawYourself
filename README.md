# DrawYourself
It provides a canvas to draw doodles and save it in data structure which can be used to redraw that doodle with animations.

## About
It is a windows form application that uses ".Net" framework and is coded in "C#". This project containes a single window which provide two canvas, one for drawing and second for displaying that doodle.
User can draw doodle on the left canvas and click on the available button to show the animation of that doodle in the right canvas.

## Future Development
* Database:
  Saving doodles in an external file along with a special name for each doodle.
* UI Tools:
  * Text Box to enter the name of doodle.
  * Save button to save the doodle in database along with its unique name.
  * Eraser to edit the doodle.
  * Clear Button to empty the canvas (although pressing the 'button 1' without any doodle will do the job).

**UPDATE :** All Above mention task are achieved other then the eraser tool for editing doodle!

## Things To Note
* The data structure used to store the doodle is a list of list. It is a list of strokes and each stroke have a list of points making a path. A single point contain the co-ordinate (x, y) of the canvas.
* Drawing each stroke with animation is achieved by drawing small straight lines between the points of the stroke with a manual delay.
* The above point explains the reason for the problem generated in drawing a single point (simply clicking the mouse) which is removed by including a simple function of filling a rectangle for drawing a single pixel.
