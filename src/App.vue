<template>
  <main class="columns is-gapless is-multiline">
    <div class="column is-1">
      <SideBar />
    </div>
    <div class="column is-11">
      <DashBoard />
    </div>
  </main>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import SideBar from "./components/Sidebar/SideBar.vue";
import DashBoard from "./components/Dashboard/DashBoard.vue";

export default defineComponent({
  name: "App",
  components: {
    SideBar,
    DashBoard
},
});
</script>

<style>
@import url("https://fonts.googleapis.com/css2?family=Poppins&display=swap");
@import url('https://fonts.google.com/specimen/Bebas+Neue');
#app {
  font-family: Poppins, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  background-color: rgb(240, 240, 240);
}

html{
  font-family: 'Poppins', sans-serif;
}

.diminish {
  width: 4em;
}

.augmentated {
  width: 95%;
}
</style>
