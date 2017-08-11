git pull -X theirs

dotnet restore
dotnet publish

sudo rm -r /var/dotnetafshin/*
sudo cp -a /home/arash/afshin/ashari-architects.com/bin/Debug/netcoreapp1.1/publish/* /var/dotnetafshin/

sudo service supervisor stop
sudo service supervisor start
