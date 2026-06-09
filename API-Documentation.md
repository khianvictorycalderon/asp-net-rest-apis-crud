# 📘 API Documentation

## Base URL
```
/api/users
```

---

## Create User

### `POST /api/users`

**Request Body**
```json
{
  "firstName": "John",
  "lastName": "Doe",
  "middleName": "M",
  "birthDate": "2000-01-01"
}
```

**Success Response (201 Created)**
```json
{
  "message": "User successfully created!"
}
```

---

## Get All Users

### `GET /api/users`

**Request Body**
```
None
```

**Success Response (200 OK)**
```json
{
  "message": "Users successfully fetched!",
  "users": [
    {
      "uid": 1,
      "firstName": "John",
      "lastName": "Doe",
      "middleName": "M",
      "birthDate": "2000-01-01"
    }
  ]
}
```

---

## Get User by ID

### `GET /api/users/{uid}`

**Path Parameters**
```
uid (integer) - required
```

**Success Response (200 OK)**
```json
{
  "uid": 1,
  "firstName": "John",
  "lastName": "Doe",
  "middleName": "M",
  "birthDate": "2000-01-01"
}
```

---

## Update User

### `PUT /api/users/{uid}`

**Path Parameters**
```
uid (integer) - required
```

**Request Body**
```json
{
  "firstName": "John",
  "lastName": "Doe",
  "middleName": "M",
  "birthDate": "2000-01-01"
}
```

**Success Response (200 OK)**
```json
{
  "message": "User successfully updated!"
}
```

---

## Delete User

### `DELETE /api/users/{uid}`

**Path Parameters**
```
uid (integer) - required
```

**Success Response (200 OK)**
```json
{
  "message": "User successfully deleted!"
}
```

---

## Error Response Format

```json
{
  "message": "Error description here",
  "error": "Optional error type",
  "status": 400
}
```