# Description

This is a program made in C# with Unity to simulate the wave interference phenomena caused by 2 elementary wave sources put inside a liquid material, as seen by the surface of the material.

It is known that in a transversal wave, such one caused by a rope or a string oscillating, the y offset of an arbitrary point p can be calculated using the formula:

![CodeCogsEqn](https://user-images.githubusercontent.com/30901594/143768619-a646a046-34be-4e1f-b6e8-fbfcb98d8f1c.png)

In this formula, A is the amplitude, T is the period of oscillation of the source, x is the distance between the source and point p and lambda is the wavelength.

Now, we can simulate a multitude of particles, in this case cubes with a side of 10 centimeters, as the surface of a liquid in which 2 vibrating cylinders are placed.
By applying this formula in 3-dimensional space where the x is changed into the distance from the individual cube to a single cylinder it is possible to create a single wave similar to the ripples created by an object that fell into stationary water. By applying this offset again with another elementary wave source at a different position, the wave interference phenomena can be visualized.

In this interpretation of the method, the 2 cylinders can be moved within the scene by using the arrow keys for the first one and the 8456 keys on the number pad to move the second one. By clicking on the "Controls" button in the bottom-right corner an user interface appears where the user can control the individual parameters of the simulation, these being the period, amplitude, and the wavelength of each of the individual cylinders.

# Images
![Wave_Interference 2021-11-28_15-03-55](https://user-images.githubusercontent.com/30901594/143768981-ab529c1c-3e03-436c-a0ef-c26dafdc46dc.png)
![Wave_Interference 2021-11-28_15-05-12](https://user-images.githubusercontent.com/30901594/143769010-129a576c-bca6-49aa-8334-78651b2af508.png)
![Wave_Interference 2021-11-28_15-06-47](https://user-images.githubusercontent.com/30901594/143769072-08192e79-1302-45a8-917f-3fafc1504d45.png)
