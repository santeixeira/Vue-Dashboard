<template>
  <NavBar/>
  <main class="container" :class="{ 'dark-mode': darkMode }">
    <div class="columns is-gapless is-multiline">
      <div class="column is-12" id="content-primary">
        <router-view/>
      </div>
      <!-- <div class="column is-6 box fixed-top" id="content-secondary">
        <SideBar @alteredTheme="altTheme" />
      </div> -->
    </div>
  </main>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import NavBar from "./components/Sidebar/NavBar.vue";
import {client} from "@/http"

export default defineComponent({
  name: "App",
  components: {
    NavBar
  },

  data() {
    return {
      darkMode: false,
    };
  },
  methods: {
    altTheme(darkMode: boolean) {
      this.darkMode = darkMode;
    },
    
  },
});
</script>

<style>
@import url("https://fonts.googleapis.com/css2?family=Poppins&display=swap");
@import url("https://fonts.google.com/specimen/Bebas+Neue");
@import url("./App.scss");
</style>
