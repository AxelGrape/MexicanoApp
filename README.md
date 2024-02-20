
Start off by cloning the repo
````
$ git clone https://github.com/AxelGrape/MexicanoApp.git
$ cd MexicanoApp
````
Build the image
````
$ docker build -t mexicano .
````
Run the app 
````
$ docker run -- mexicano -d -p 5002:8080 --rm mexicano
````
Visit http://localhost:5002/
