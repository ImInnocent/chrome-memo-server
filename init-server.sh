# Update yum
sudo yum update -y

# Install git
sudo yum install git -y

# git clone 
git clone https://github.com/ImInnocent/chrome-memo-server

# checkout git branch
cd chrome-memo-server
git checkout develop

# install dotnet
sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
sudo yum install dotnet-sdk-5.0 -y

# copy nginx package info
sudo cp ~/nginx.repo /etc/yum.repos.d/nginx.repo

# install nginx
sudo yum install nginx -y

# install firewalld
sudo yum install firewalld -y

# apply firewall service
sudo systemctl unmask firewalld
sudo systemctl enable firewalld
sudo systemctl start firewalld

# open port 80
sudo firewall-cmd --permanent --zone=public --add-port=80/tcp

# reload firewall
sudo firewall-cmd --reload

# apply nginx service
sudo systemctl enable nginx
sudo systemctl start nginx
