
[![Build Status](https://travis-ci.com/ammarnajjar/amicroservice.svg?branch=master)](https://travis-ci.com/ammarnajjar/amicroservice)


# Simple Microservice with Webapi

To run using docker:

```bash
docker-compose up
```

## End Points

### /api/users


- `GET`: returns a list of users

```JSON
[
  {
    "id": 1,
    "name": "first"
  },
  {
    "id": 2,
    "name": "second"
  }
]
```

### /api/computer

This is an example of implement [builder](https://en.wikipedia.org/wiki/Builder_pattern) design pattern.

- `GET`: returns a list of computers

```JSON
[
  {
    "cpu": "LaptopCPU",
    "mark": "",
    "gpu": "LaptopGPU",
    "ram": "16GB",
    "color": "LaptopBlack",
    "resolution": "LaptopResolution"
  },
  {
    "cpu": "SuperCPU",
    "mark": "",
    "gpu": "SuperGPU",
    "ram": "256GB",
    "color": "SuperBlack",
    "resolution": "SuperResolution"
  }
]
```

### /api/pizza

This is an example of implement [factory](https://en.wikipedia.org/wiki/Factory_method_pattern) design pattern.

- `GET`: `/api/pizza` to reutrn list of pizzas
- `GET`: `/api/pizza/{id}` to reutrn pizza with id
- `POST`: `/api/pizza` to add pizza to the list
Request body:

```JSON
{
	"id": 5,
	"name": "new Pizza",
	"category": "new Category"
}
```

- `PUT`: `/api/pizza/{id}` to update pizza in the list
Request body:

```JSON
{
	"id": 5,
	"name": "modified name",
	"category": "modified category"
}
```

- `DELETE`: `/api/pizza/{id}` to remove pizza with id from the list
