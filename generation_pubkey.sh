
##### REVERB Project ######## Polytech Sorbonne - 2018/2019 #########

#Encadrant : François PÊCHEUX 

#Participants : Yassine ABBAR - Aurélien ABEL - Fatine BENTIRES ALJ - Geng REN - Alexia ZOUNIAS-SIRABELLA

#!/bin/bash


for i in `seq 1 5`; 
    do
        openssl genrsa -out ./private_keys/private{$i}.pem 1024 #generation of the private key
        openssl rsa -in ./private_keys/private{$i}.pem -pubout -out ./public_keys/public{$i}.pem
    done 