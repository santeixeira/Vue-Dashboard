import { createRouter, createWebHashHistory, RouteRecordRaw } from "vue-router";
import DashBoard from "@/pages/DashBoard.vue";
import Vagas from "@/pages/Vagas.vue";
import Register from "@/pages/Register.vue";
import ForgotPassword from "@/pages/ForgotPassword.vue";

import Login from "@/pages/Auth/Login.vue";
import FormForgot from "@/pages/Auth/FormForgot.vue";
import MessageForgot from "@/pages/Misc/MessageForgot.vue"

import Credentials from "@/pages/Register/Credentials.vue";
import DevEmail from "@/pages/Register/DevEmail.vue";
import Job from "@/pages/Register/Job.vue";
import Skill from "@/pages/Register/Skill.vue";
import Experiences from "@/pages/Register/Experiences.vue";
import Personal from "@/pages/Register/Personal.vue";
import Diversity from "@/pages/Register/Diversity.vue";
import Social from "@/pages/Register/Social.vue"
import Completed from "@/pages/Register/Completed.vue"

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
    component: ForgotPassword,
    children: [
      {
        path: "",
        name: "FormForgot",
        component: FormForgot
      },
      {
        path: "/message",
        name: "MessageForgot",
        component: MessageForgot
      }
    ]
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
        name: "Credentials",
        component: Credentials,
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
        path: "/social",
        name: "Social",
        component: Social,
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
      {
        path: "/completed",
        name: "Completed",
        component: Completed,
      },
    ]
  },
  
];

const router = createRouter({
  history: createWebHashHistory(),
  routes: routes,
});

export default router;
