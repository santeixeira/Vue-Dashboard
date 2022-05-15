import { createRouter, createWebHashHistory, RouteRecordRaw } from "vue-router"
import DashBoard from '../views/DashBoard.vue'
import Vagas from '../views/Vagas.vue'

const routes: RouteRecordRaw[] = [
  {
    path: '/dashboard',
    name: 'DashBoard',
    component: DashBoard
  },
  {
    path: '/vagas',
    name: 'Vagas',
    component: Vagas
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes: routes,
})

export default router;