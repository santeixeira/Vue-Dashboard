<template>
  <Transition>
    <main
    class="columns is-gapless is-multiline"
    :class="{ 'dark-mode': darkMode }"
    
  >
    <div class="column is-2 content-secondary">
      <SideBar @alteredTheme="altTheme" />
    </div>
    <div class="column is-10 content-primary">
      <DashBoard @alteredTheme="altTheme" />
    </div>
  </main>
  </Transition>
  
</template>

<script lang="ts">
import { defineComponent } from "vue";
import SideBar from "./components/Sidebar/SideBar.vue";
import DashBoard from "./components/Dashboard/DashBoard.vue";

export default defineComponent({
  name: "App",
  components: {
    SideBar,
    DashBoard,
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
