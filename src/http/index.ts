import axios, { AxiosInstance } from "axios"

export const client: AxiosInstance = axios.create({
  baseURL: "https://jobi-api.herokuapp.com"
})

