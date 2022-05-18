import { createRouter, createWebHashHistory, RouteRecordRaw } from "vue-router"
import DashBoard from '../views/DashBoard.vue'
import Vagas from '../views/Vagas.vue'
import Login from '../components/Register/Login.vue'
import DevRegister from '../components/Register/DevRegister.vue'
import DevSobre from '../components/Register/DevSobre.vue'
import DevRegisterCarreira from '../components/Register/DevRegisterCarreira.vue'

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
  },
  {
    path: '/login',
    name: 'Login',
    component: Login
  },
  {
    path: '/register',
    name: 'DevRegister',
    component: DevRegister
  },
  {
    path: '/register/carreira',
    name: 'DevRegisterCarreira',
    component: DevRegisterCarreira
  },
  {
    path: '/register/sobre',
    name: 'DevSobre',
    component: DevSobre
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes: routes,
})

export default router;