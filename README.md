# otus_architecture_lab_8

IHandler - интерфейс цепочки обязанностей. его реализует FileParcerBase от которого наследуються классы конкретных парсеров: FileParserJson, FileParserCsv, FileParserTxt, FileParserXml.

Для обеспечения всем парсерам доступа к логу используется локатор сервисов.

![alt text](https://github.com/AlexandrBashkirev/otus_architecture_lab_8/blob/master/class_diagram.png?raw=true)
