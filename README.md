# SDML.NET


SDML.NET is open source library, based on .NET Standard platform.

SDML (Solution Description Markup Language) provides bunch of tags and attributes, which will help developers describe their solution up to details like methods parameters, types of properties, references, hierarchy of inheriting and so on. It will generate SDML documents, based on input data. Also, it will be able to generate SDML data automatically by using .NET reflection mechanismes.

Currently there is no clear specification for SDML standard and I still implement new ways to describe solutions.
SDML pretends to be user friendly, i.e. be easy to read without any rendering.

Is this usefull? Well, I don't know. Basically it could be. Right now I imagine the next use cases for SDML:
 - well formed document with described solution will allow newcomers investigate the project faster and easier;
 - can be used for solution design as a model;
 - can be used as precise task description.
 
Currently SDML allows only to desscribe solutions structure, but soon I plan to add elements to describe processes and used architectural and design patters.

There are no hard requirements to document - you can even put the code into it, it's all up to you. But this is not reccomended approach. Despite the fact that SDML document pretends to be the part of project documentation, code parts in it can break up the security of solution.

I'm a student master and this is my masters project. Also, I'm not a real programmer, just a trainee.
Although I have a job and I cannot spend all my time on it, plus deadline is far away, so I don't have to push myself.

As far as that there is no specification for it, I decided to develop library first, and then write specification.

Here's the example of standart SDML document (writeen handly):

