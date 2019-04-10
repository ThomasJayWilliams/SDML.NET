# SDML.NET


SDML.NET is an open source library, based on .NET Standard platform.

SDML (Solution Description Markup Language) provides bunch of elements and attributes, which will help developers describe their solutions up to details, like methods parameters, types of properties, references, hierarchy of inheriting and so on. It will generate SDML documents, based on input data. Also, it will be able to generate SDML data automatically by using .NET reflection mechanismes.

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

But in spite of this I will be happy to get any help with developing library and standard as well. But, if you want to contribute, please, create another branch with short name of your changes and send me a merge request.
Also, anticipating questions I want to explain why I started to creating own generator rather then used another, prooven by time generators like LINQ to XML - I've just wanted to create it on my own. This is quite awesome experience and I like to projects like this one. Besides, later I'm planning to add more tools, like process describing and the XML tools might be not enough to effective implement the these instruments.

As far as that there is no specification for it, I decided to develop library first, and then write specification.

Here's the example of standart SDML document (written handly):

SDML.NET/docs/examples/example.sdml
```xml
<Document Name="Example">
    <Solution Name="SDML.NET" Type=".NET Standard Library">
        <Description>
            This is example of SDML standard. It describes SDML.NET solution.
        </Description>
        <Dependency Name="Microsoft.NETCore.App" />
        <Project Name="SDML.NET" Type="Library">
            <Description Name="Basic description">
                This is the main solution project.
                It connects all other projects and presents the generator API.
            </Description>
            <Interface Name="ISDMLGenerator" Location="SDML.NET/ISDMLGenerator.cs"
                Access="Public" Namespace="SDML.NET">
                <!-- I'm still not sure what attribute will be better here - Name or Value -->
                <Reference Value="SDML.NET.Core.Infrastructure.Abstractions" />
                <Reference Value="System.Threading.Tasks">
                <Method Name="Save" RetunType="Void" Access="Public" IsAbstract="True" IsStatic="False">
                    <Description>
                        Implementation of this method will save .sdml document on disk.
                    </Description>
                    <Parameter Name="path" Type="string">
                </Method>
                <Method Name="Serialize" ReturnType="string" Access="Public" IsAbstract="True">
                    <Description>
                        Implementation of this method will format SDML text from object.
                    </Description>
                </Method>
            </Interface>
            <Class Name="SDMLGenerator" Access="Public" Namespace="SDML.NET">
                <Description>
                    This class implements ISDMLGenerator and provides SDML.NET generator API.
                </Description>
                <Parent Name="ISDMLGenerator" Type="Interface" />
                <Property Name="Document" Access="Public" WritingAccess="Private" ReadingAccess="Public" />
                <Method Name="Build" Access="Public" IsAbstract="False" ReturnType="Void">
                    <Desciption>
                        This method builds data hierarchy from input objects.
                    </Desciption>
                    <Parameter Name="sourceElement" Type="SDML.Core.Infrastructure.Abstractions.ISDMLDataElement" />
                </Method>
                <Method Name="Serialize" Access="Public" ReturnType="Task<string>" IsAsync="True">
                    <Description>This method serializes structure, built by Build() into string.</Desciption>
                </Method>
            </Class>
        </Project>
    </Solution>
</Document>
```



Currently SDML.NET supports the following generation mechanic:

SDML.NET.TestCLI.Program.cs
```cs
public static void GetSdml()
{
    var data = new SdmlDocument(
        new SdmlNameAttribute("Sdml.NET Library Description"),
        new SdmlSolution(
            new SdmlNameAttribute("Sdml.NET"),
            new SdmlTypeAttribute(".NET Standard Library"),
            new SdmlProject(
                new SdmlNameAttribute("Sdml.NET"),
                new SdmlClass(
                    new SdmlNameAttribute("InvalidNodeException"),
                    new SdmlMethod(
                        new SdmlNameAttribute("ThisMethodDoesNotEvenExist"),
                        new SdmlDescription(
                            "This is some random method. And this is its description.",
                            new SdmlNameAttribute("ExampleDescription")))))));

    var serializer = new SdmlSerializer();
    Console.WriteLine(serializer.Serialize(data));
}
```
