# move this script to ~
cd ~


## 1. Git Repository Cloning and setting
# git clone
git clone https://github.com/ImInnocent/chrome-memo-server

# change branch
cd chrome-memo-server
git checkout develop



## 2. install dotnet
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0



## 3. install nginx
# install nginx
sudo apt-get update
sudo apt-get install -y nginx

# start nginx server
sudo service nginx stop
sudo service nginx start

# copy nginx setting file
sudo cp ~/default /etc/nginx/sites-available/default

# reload nginx setting
sudo nginx -s reload



## 4. install supervisor
# install supervisor
sudo apt-get install -y supervisor

# copy supervisor setting file
sudo cp ~/chrome-memo-server.conf /etc/supervisor/conf.d/chrome-memo-server.conf



## 5. dotnet publish and move .dll file
# publish dotnet application
cd ~/chrome-memo-server
dotnet publish -c Release

# move contents
sudo mkdir /var/aspnetcore
sudo cp -r ~/chrome-memo-server/bin/Release/net5.0/publish/ /var/aspnetcore/
sudo rm -rf /var/aspnetcore/chrome-memo-server
sudo mv /var/aspnetcore/publish/ /var/aspnetcore/chrome-memo-server



## 6. start supervisor
sudo service supervisor stop
sudo service supervisor start
