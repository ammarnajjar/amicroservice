v0.1.0 / 2019-05-07
===================

* d8b4093 test(adapter): cover adapter models with unittests

* 8fffc5e feat(adapter): add end-point to README

* f5f7f87 feat(adapter): add adapter pattern example

this includs end-point

* e6b83f5 try disco distro for travis ci
* c1a5911 update dotnet to 2.2 in travis ci
* e430d03 use only dotnet 2.1.502 in travis ci
* 78b9e2d add travis ci badge
* eeeb0aa downgrade dotnet to 2.2 in travis ci
* f0508e1 ci(travis): add travis.yml file

* 90beb20 test(builder): add tests

Cover builder pattern example unit tests

* 1aab304 feat(builder): add builder pattern example

- refactor patterns in directories
- add end-points

* e73955b test(Models): add tests for Models

Also remove the tests for Controllers
for after discussion, testing end-points
is more like testing dotnet frameworks
functionality themselves.

* bf0780e docs(Readme): move README to repository root

* 5b8f741 test(Controllers): starting with NUnit testing

Not working yet, but to keep in progress track.

* e40eba9 refactor(PizzaController): use IDbContext

This is not working.. but to keep in history

* a9a5424 fix(PizzaController): check if context null before using it

also change the get method to async

* 4fc4414 fix(Docker): move inside src dir before building

* e11e207 refacto(src): move code to src directory

this is an introduction step for adding a test project

* 1020fb7 fix(Docker): correct the path for build in container

* 391daf4 feat(FactoryPattern): add Pizza Factory

and experiment with the different http request types:

- GET, POST, PUT, DELETE

* 9e177a3 faet(Controllers): add UsersController

* da5028d feat(amicroservice): Initial Commit

Bare bones webapi dotnet project
