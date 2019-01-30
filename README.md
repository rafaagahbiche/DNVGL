
---
### DNV GL Recruitment Assignment
---

# Author: Abderrafaa Gahbiche
# Date: 30 Jan 2019

---
### The Solution contains these projects
---

1. cubes.Data
	This is the data layer where the Cube model is defined and CubesSpace is like the repository. 
	This layer could be used to extract data from an external source by adding the basic operations on a data source (CRUD operations).

2. cubes.Service
	All the operations that could be applied on cubes are implemented here

3. cubes.UI
	- The controller and the different views of the application. 
	- Ninject used here for dependency injection.
	- In the main view, the number of cubes that can be added is limited to two.
	- Javascript file contains jQuery functionalities for asynchronous calls. 
	- CSS file

---
### Things Not Implemented
---
	- The implementation of the intersection
	- Unit Testing
	- Connection to data source such XML file or Data base
