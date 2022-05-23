import { createRouter, createWebHashHistory, RouteRecordRaw } from "vue-router";
import DashBoard from "@/views/DashBoard.vue";
import Vagas from "@/views/Vagas.vue";
import Register from "@/views/Register.vue";
import Login from "@/components/Register/Login.vue";
import ForgotPassword from "@/components/Register/ForgotPassword.vue";

import Credencials from "@/components/Register/Credencials.vue";
import DevEmail from "@/components/Register/DevEmail.vue";
import Job from "@/components/Register/Job.vue";
import Skill from "@/components/Register/Skill.vue";
import Experiences from "@/components/Register/Experiences.vue";
import Personal from "@/components/Register/Personal.vue";
import Diversity from "@/components/Register/Diversity.vue";

const routes: RouteRecordRaw[] = [
  {
    path: "/dashboard",
    name: "DashBoard",
    component: DashBoard,
  },
  {
    path: "/vagas",
    name: "Vagas",
    component: Vagas,
  },
  {
    path: "/login",
    name: "Login",
    component: Login,
  },
  {
    path: "/forgot-password",
    name: "ForgotPassword",
    component: ForgotPassword,
  },
  {
    path: "/register/email",
    name: "DevEmail",
    component: DevEmail,
  },
  {
    path: "/register",
    component: Register,
    children: [
      
      {
        path: "",
        name: "Credencials",
        component: Credencials,
      },
      {
        path: "/personal",
        name: "Personal",
        component: Personal,
      },
      {
        path: "/diversity",
        name: "Diversity",
        component: Diversity,
      },
      {
        path: "/carreira",
        name: "Job",
        component: Job,
      },
      {
        path: "/skill",
        name: "Skill",
        component: Skill,
      },
      {
        path: "/experiences",
        name: "Experiences",
        component: Experiences,
      },
    ]
  },
  
];

const router = createRouter({
  history: createWebHashHistory(),
  routes: routes,
});

export default router;
