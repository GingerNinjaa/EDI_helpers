# Import Module
import os
  
# Folder Path Remote path is working fine 
path = r"Your_Path"

  
# Change the directory
os.chdir(path)
  
# Read text File
def read_text_file(file_path):
    with open(file_path,'r') as file:
        strip = file.read()
        PO_Numbers = strip.split(' ', 1)[0]
        Date = strip.split()[5]
        print("PO NUMBER --->   " + PO_Numbers + "  Delivery date wanted  --->   " + Date[0:8] )


  
# iterate through all file
for file in os.listdir():
    # Check whether file is in text format or not
    if file.endswith(".asc"):
        file_path = f"{path}\{file}"
        # call read text file function
        read_text_file( file_path)
        
        
        
