

Jack Bonner, Kelly Deli coding examination 6/12/22


I began the process by starting a new project in visual studio, luckily such a robust IDE has most of the trappings already set up 
and it's a matter of filling in the blanks. I Started by reading adding the json file to the solution, then reading it in. 
This was done with the widely used Newtonsoft.Json framework. Easy to use and powerful led it to be a good solution. I set up a new controller
for the Shops page as it would be the logic behind reading in the JSON file. After reading
in the file I set to work displaying the information. I used the resources I had - preset and ready to render information 
that existed on the company site. If this goes against the rules I apologize, but I thought it necessary to begin to use company styling.

I made one replacement with the font, using Lato instead of apercu as apercu was a paid font and Lato is free and on google. The bulk of the
time was spent styling the page making sure it worked in a mobile environment.

Had I more time, I think I would have made the home page a bit nicer. It's a little underwhelming but as I wanted to submit this ASAP with the 
other parts of the test.







The Sushi Daily team would like to give users the ability to apply for an artisan job role via the website.

The team envisage a form on the artisan page, which asks the user to upload their CV.

Currently the website utilises Sprout (Sushi Daily CRM) forms however, Sprout does not have the functionality which includes a CV upload.

What is your proposed solution?

Please consider:

Where you would save the CV uploads
Any concern about storage and performances
GDPR
Possible technologies involved
Any concerns you may have in the solution you propose


Before setting out building a custom intake form, I would see if .NET has any tried and true platforms that take files and examine them. 
I don't think that spending weeks building out a custom file intake would be productive, if one exists and is used on sites like 
workday, linkedin, and other career sites. if I had to set about building a custom cv upload from scratch, I would do some research into how the pre-built ones are done. 
I would then make a scanner that would read in the file, then look for common areas such as education, work experience, extra curriculars etc. If I had no space on the
CRM I would create a new database, likely using azure, to store them and their information taken from parsing through the file. The only issue I see from this
is an imperfect scanner will rule out candidates who may otherwise be qualified. Thus using an established or open-source data entry platform may be advisable. 