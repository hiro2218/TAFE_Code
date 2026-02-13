
# ColourLerp

You are tasked with writing a program that will create a linear interpolation between two pixels. You are to read in two pixel values that will be represented as hex values and generate a number of pixels specified between them.

Input for the program:
``` 
Enter the first colour: 0x002222
Enter the second colour: 0xFFDD33
Enter the number of colours to generate inbetween: 3
```


Using the 2 pixels specified it will generate 3 new pixels between the first and last pixel. You will need to round the difference of each channel between the larger and smaller pixel. (Edit, I have updated it so you need to round the channels not the pixels themselves).

You will find the channel (Red, Green, Blue) difference between the two pixels and divide by the number of total pixels create the new pixels.

```
Colours:
0x002222
0x405126
0x80802a
0xc0af2e
0xffdd33
```

Your program will need to swap the starting pixel (or smallest) out of the two that were inputted should be the first colour shown while the larger pixel should be the last pixel specified.

Example 1:

```
Enter the first pixel: 0x002222
Enter the second pixel: 0xFFDD33
Enter the number of colours to generate inbetween: 3
Colours:
0x002222
0x405126
0x80802a
0xc0af2e
0xffdd33
```


Example 2 (Reversed):

```
Enter the first pixel: 0xFFDD33
Enter the second pixel: 0x002222
Enter the number of colours to generate inbetween: 3
Colours:
0x002222
0x405126
0x80802a
0xc0af2e
0xffdd33
```
