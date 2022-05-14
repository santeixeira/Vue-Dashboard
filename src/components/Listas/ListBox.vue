<template>
  <div class="box">
    <slot></slot>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent ({
  name: 'ListBox',
})
</script>

<style>
@import url('./style.scss')
</style>
