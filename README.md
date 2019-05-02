# Simple Webapi

To run using docker:

```bash
docker-compose up
```

## End Points

### /api/users

- `GET`: returns a list of users

### /api/pizza

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
