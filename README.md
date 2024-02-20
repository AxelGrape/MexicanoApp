**Prerequisites:**  
Docker desktop [Windows](https://www.docker.com/products/docker-desktop/) [Ubuntu](https://docs.docker.com/engine/install/ubuntu/)  
Git [Windows](https://git-scm.com/download/win) [Ubuntu](https://git-scm.com/download/linux)  


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
$ docker run --name mexicano -d -p 5002:8080 --rm mexicano
````
Visit http://localhost:5002/
